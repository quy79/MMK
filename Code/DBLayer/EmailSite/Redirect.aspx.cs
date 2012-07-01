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
            String url = "";
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
            if (context.Request.Params["REDIRECTURL"] != null)
            {
                try
                {
                    url = (String)context.Request.Params["REDIRECTURL"];
                }
                catch
                {
                    url = "";
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
                context.Response.Redirect(url);

                // context.Response.End();
                return;


            }
        }
    }
}