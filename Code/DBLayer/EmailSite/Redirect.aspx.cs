using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseLayer;
using System.Data;
namespace EmailSite
{
    public partial class Redirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            int autoID = 0;
            int messageID = 0;
            int listID = 0;
            // String url = "";
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
                String url = temp[3].Split('=')[1];
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
                        if (String.IsNullOrEmpty(url))
                        { // open
                            obj.COUNTCLICK = 0;
                            obj.COUNTOPEN = 1;
                        }
                        else
                        { //click
                            obj.COUNTCLICK = 1;
                            obj.COUNTOPEN = 0;
                        }

                        obj.Insert();
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(url))
                        { // open
                            obj.COUNTCLICK = countclick;
                            obj.COUNTOPEN = countopen + 1;
                        }
                        else
                        { //click
                            obj.COUNTCLICK = countclick + 1;
                            obj.COUNTOPEN = countopen;
                        }

                        obj.Update();
                    }
                    context.Response.Redirect(url.Replace("'",""));

                    // context.Response.End();
                    return;





                }
            }
        }
            
        public string Decode(string str)
        {
            byte[] decbuff = Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(decbuff);
        }
    }
}