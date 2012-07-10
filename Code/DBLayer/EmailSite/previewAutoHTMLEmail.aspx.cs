using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class previewAutoHTMLEmail : System.Web.UI.Page
    {
        public string strListName = "";
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
                    lblListName.Text = objDT.Rows[0]["LISTNAME"].ToString();
                }

                DatabaseLayer.Messages objMsg = new DatabaseLayer.Messages();
                objMsg.ID = Int32.Parse(hdMsgID.Value);
                objDT = objMsg.SelectByID();
                if (objDT != null)
                {
                    lblFrom.Text = objDT.Rows[0]["FROM"].ToString();
                    lblSubject.Text = objDT.Rows[0]["SUBJECT"].ToString();
                    lblMsgName.Text = objDT.Rows[0]["MESSAGENAME"].ToString();
                    lblMsgContent.Text = objDT.Rows[0]["BODY"].ToString();
                }

            }
            catch { }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DatabaseLayer.Autoresponder_messages obj = new DatabaseLayer.Autoresponder_messages();
            obj.AUTORESPONDERID = Int32.Parse(hdAutoID.Value);
            obj.MESSAGEID = Int32.Parse(hdMsgID.Value);
            obj.STATUS = 1;
            obj.ENDDATE = DateTime.MinValue;
            obj.Insert();
            Response.Redirect("createAutoMsgDone.aspx?Aid=" + hdAutoID.Value + "&Msgid=" + hdMsgID.Value);
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("createAutoHTMLEmail.aspx?Aid=" + hdAutoID.Value + "&Msgid=" + hdMsgID.Value);
        }
    }
}