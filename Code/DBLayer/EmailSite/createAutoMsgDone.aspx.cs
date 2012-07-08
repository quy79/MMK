using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class createAutoMsgDone : System.Web.UI.Page
    {
        public string strListName;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Utils.CheckSecurity(Session, Response);
                hdAutoID.Value = Request["Aid"];
                hdMsgID.Value = Request["Msgid"];
                DatabaseLayer.Autoresponder objList = new DatabaseLayer.Autoresponder();
                objList.ID = Int32.Parse(hdAutoID.Value);
                DataTable objDT = objList.SelectByID();
                if (objDT != null)
                {
                    strListName = objDT.Rows[0]["NAME"].ToString();
                    
                }
            }
            catch { }
        }

        protected void lnkMyAutoresponder_Click(object sender, EventArgs e)
        {
            Response.Redirect("myAutoresponders.aspx");
        }

        protected void lnkCreatOther_Click(object sender, EventArgs e)
        {
            Response.Redirect("createAutoMsg.aspx?Aid=" + hdAutoID.Value);
        }
    }
}