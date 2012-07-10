using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseLayer;
using System.Data;
namespace EmailSite
{
    /// <summary>
    /// Summary description for imageHandler
    /// </summary>
    public class imageHandler : IHttpHandler
    {

        
            public void ProcessRequest(System.Web.HttpContext context)
        {
            int autoID = 0;
            int messageID = 0;
            int listID = 0;
            int contactID=0;
            // Encode("AUTORESPONDERID=" + autoresponderID + "&MESSAGEID=" + messageID + "&LISTID=" + listID)
            //empty.jpg?paramcode=QVVUT1JFU1BPTkRFUklEPTMmTUVTU0FHRUlEPTImTElTVElEPTMy


             String param = "";
            if (context.Request.Params["paramcode"] != null)
            {
                try
                {
                    param = (String)context.Request.Params["paramcode"];
                }
                catch
                {
                    param = "";
                }
            }
            if (!String.IsNullOrEmpty(param))
            {
                // Encode("AUTORESPONDERID=" + autoresponderID + "&MESSAGEID=" + messageID + "&LISTID=" + listID + "&REDIRECTURL=" + link.Replace("\"", "") + "'");
               // param = param.Substring(0, param.Length - 1);
                String paremdecode = Decode(param);
                String[] temp = paremdecode.Split('&');
                String _autoD = temp[0].Split('=')[1];

                String _mesageID = temp[1].Split('=')[1];
                String _listID = temp[2].Split('=')[1];
               // String url = temp[3].Split('=')[1];
                try
                {
                    autoID = int.Parse(_autoD);
                }
                catch
                {
                    autoID = 0;
                }
                try
                {
                    messageID = int.Parse(_mesageID);
                }
                catch
                {
                    messageID = 0;
                }

                try
                {
                    listID = int.Parse(_listID);
                }
                catch
                {
                    listID = 0;
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
                else
                {
                    String _contactID = temp[3].Split('=')[1];
                    try
                    {
                        contactID = int.Parse(_contactID);
                    }
                    catch
                    {
                        contactID = 0;
                    }

                    MessageClickOpenStatus obj = new MessageClickOpenStatus();
                    obj.CONTACTID = contactID;
                    obj.MESSAGEID = messageID;
                    obj.LISTID = listID;
                    int countclick = 0;
                    int countopen = 0;
                    DataTable dt = obj.Select();
                    bool newItem = true;
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        countclick = int.Parse(row[3].ToString());
                        countopen = int.Parse(row[4].ToString());
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
            }



         
            context.Response.Clear();
            context.Response.ContentType = "Image/jpeg";
            context.Response.WriteFile("empty.jpg");
            context.Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
        public string Decode(string str)
        {
            byte[] decbuff = Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(decbuff);
        }
    }
}