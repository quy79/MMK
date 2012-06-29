using System;
using System.Web;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Data;

using DatabaseLayer;
namespace ImageHandler
{
    public class HttpImageHandler : IHttpHandler
    {

        int Width = 0;
        int Height = 0;

        public void ProcessRequest(System.Web.HttpContext context)
        {
            int autoID = 0;
            int messageID = 0;
            int listID = 0;
            if (context.Request.Params["AUTORESPONDERID"] != null)
            {
                try
                {
                    autoID = int.Parse(context.Request.Params["AUTORESPONDERID"]);
                }
                catch
                {
                    autoID = 0;
                }
            }
            if (context.Request.Params["MESSAGEID"] != null)
            {
                try
                {
                    messageID = int.Parse(context.Request.Params["MESSAGEID"]);
                }
                catch
                {
                    messageID = 0;
                }
            }
            if (context.Request.Params["LISTID"] != null)
            {
                try
                {
                    listID = int.Parse(context.Request.Params["LISTID"]);
                }
                catch
                {
                    listID = 0;
                }
            }
            if (autoID > 0)
            {



                ClickOpenStatus obj = new ClickOpenStatus();
                obj.AUTORESPONDERID = autoID;
                obj.MESSAGEID = messageID;
                obj.LISTID = listID;
                int countclick = 0;
                int countopen = 0;
                DataTable dt = obj.Select();
                bool newItem = true;
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    countclick = int.Parse(row[4].ToString());
                    countopen = int.Parse(row[5].ToString());
                    newItem = false;
                }
                if (newItem)
                {
                    obj.COUNTCLICK = 0;
                    obj.COUNTOPEN = 1;
                    obj.Insert();
                }
                else
                {
                    obj.COUNTCLICK = countclick;
                    obj.COUNTOPEN = countopen + 1;
                    obj.Update();
                }

               
            }
            context.Response.Clear();
            context.Response.ContentType = getContentType(context.Request.PhysicalPath);
            context.Response.WriteFile(context.Request.PhysicalPath);
            context.Response.End();
        }
        public void ProcessRequest1(System.Web.HttpContext context)
        {
            Debug.WriteLine("ProcessRequest image");
            if (context.Request.Params["height"] != null)
            {
                try
                {
                    Height = int.Parse(context.Request.Params["height"]);
                }
                catch
                {
                    Height = 0;
                }
            }

            if (context.Request.Params["width"] != null)
            {
                try
                {
                    Width = int.Parse(context.Request.Params["width"]);
                }
                catch
                {
                    Width = 0;
                }
            }

            if (Width <= 0 && Height <= 0)
            {

                context.Response.Clear();
                context.Response.ContentType = getContentType(context.Request.PhysicalPath);
                context.Response.WriteFile(context.Request.PhysicalPath);
                context.Response.End();

            }
            else
            {
                context.Response.Clear();
                context.Response.ContentType = getContentType(context.Request.PhysicalPath);
                byte[] buffer = getResizedImage(context.Request.PhysicalPath, Width, Height);
                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                context.Response.End();

            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        byte[] getResizedImage(String path, int width, int height)
        {
            Bitmap imgIn = new Bitmap(path);
            double y = imgIn.Height;
            double x = imgIn.Width;

            double factor = 1;
            if (width > 0)
            {
                factor = width / x;
            }
            else if (height > 0)
            {
                factor = height / y;
            }
            System.IO.MemoryStream outStream = new System.IO.MemoryStream();
            Bitmap imgOut = new Bitmap((int)(x * factor), (int)(y * factor));
            Graphics g = Graphics.FromImage(imgOut);
            g.Clear(Color.White);

            g.DrawImage(imgIn, new Rectangle(0, 0, (int)(factor * x), (int)(factor * y)), new Rectangle(0, 0, (int)x, (int)y), GraphicsUnit.Pixel);

            imgOut.Save(outStream, getImageFormat(path));
            return outStream.ToArray();
        }

        string getContentType(String path)
        {
            switch (Path.GetExtension(path))
            {
                case ".bmp": return "Image/bmp";
                case ".gif": return "Image/gif";
                case ".jpg": return "Image/jpeg";
                case ".png": return "Image/png";
                default: break;
            }
            return "";
        }

        ImageFormat getImageFormat(String path)
        {
            switch (Path.GetExtension(path))
            {
                case ".bmp": return ImageFormat.Bmp;
                case ".gif": return ImageFormat.Gif;
                case ".jpg": return ImageFormat.Jpeg;
                case ".png": return ImageFormat.Png;
                default: break;
            }
            return ImageFormat.Jpeg;
        }
    }
}
