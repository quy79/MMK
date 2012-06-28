using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChilkatEmail;
using ChilkatEmail.Utils;

namespace EmailSite
{
    public partial class createAutoTextEmail : System.Web.UI.Page
    {
        public string strListName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Utils.CheckSecurity(Session, Response);
                if (!IsPostBack)
                {
                    hdAutoID.Value = Request["Aid"];
                    hdMsgID.Value = Request["Msgid"];
                    

                    DatabaseLayer.Autoresponder objList = new DatabaseLayer.Autoresponder();
                    objList.ID = Int32.Parse(hdAutoID.Value);
                    DataTable objDT = objList.SelectByID();
                    if (objDT != null) strListName = objDT.Rows[0]["NAME"].ToString();

                    if (hdMsgID.Value != "")
                    {
                        DatabaseLayer.Messages objMsg = new DatabaseLayer.Messages();
                        objMsg.ID = Int32.Parse(hdMsgID.Value);
                        objDT = objMsg.SelectByID();
                        if (objDT != null)
                        {
                            txtFromEmail.Text = objDT.Rows[0]["FROM"].ToString();
                            txtSubject.Text = objDT.Rows[0]["SUBJECT"].ToString();
                            txtMsgName.Text = objDT.Rows[0]["MESSAGENAME"].ToString();
                            txtMsgBody.Text = objDT.Rows[0]["BODY"].ToString();
                        }
                    }
                }
            }
            catch { }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           

            DatabaseLayer.Messages objMsg = new DatabaseLayer.Messages();
            objMsg.USERID = Int32.Parse(Session["userID"].ToString());
            objMsg.FROM = txtFromEmail.Text.Trim();
            objMsg.SUBJECT = txtSubject.Text.Trim();
            objMsg.MESSAGENAME = txtMsgName.Text.Trim();
            objMsg.BODY = txtMsgBody.Text.Trim();
            objMsg.STATUS = 1;
            objMsg.TYPE = 1;
            int idMsg = 0;
            if (hdMsgID.Value != "") //edit mode
            {
                idMsg = Int32.Parse(hdMsgID.Value);
                objMsg.ID = idMsg;
                objMsg.Update2();
            }else idMsg = objMsg.Insert();

            Response.Redirect("previewAutoTextEmail.aspx?Aid=" + hdAutoID.Value + "&Msgid=" + idMsg.ToString());


        }

        protected void btnSpam_Click(object sender, EventArgs e)
        {
            SpamcheckServices spamcheck = new SpamcheckServices();
            bool isSpam = spamcheck.SpamHTMLChecking(txtFromEmail.Text);
            if (isSpam) lblMsg.Text = Utils.ShowMessage("This email is a spam email.", true);
            else lblMsg.Text = Utils.ShowMessage("This email is not a spam email.", false);
        }

    }
}