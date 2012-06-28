using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class editMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try{
            string strID = Request["id"];
            DatabaseLayer.Messages obj = new DatabaseLayer.Messages();
            obj.ID = Int32.Parse(strID);
            DataTable dt = obj.SelectAutoMsgByID();
            string autoID = dt.Rows[0]["AUTORESPONDERID"].ToString();
            int type = 1;
            try { type = Int32.Parse(dt.Rows[0]["TYPE"].ToString()); }
            catch { }
           
            if (type == 1) Response.Redirect("createAutoTextEmail.aspx?Aid=" + autoID + "&Msgid=" + strID);
            else Response.Redirect("createAutoHTMLEmail.aspx?Aid=" + autoID + "&Msgid=" + strID);
            }catch {

            }
        }
    }
}