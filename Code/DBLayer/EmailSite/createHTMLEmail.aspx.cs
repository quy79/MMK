using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChilkatEmail;

using ChilkatEmail.Utils;
namespace EmailSite
{
    public partial class createHTMLEmail : System.Web.UI.Page
    {
        private delegate void CheckMail();
        protected void Page_Load(object sender, EventArgs e)
        {
            Utils.CheckSecurity(Session, Response);
            if (!IsPostBack)
            {
                if (Session["currentTextEmail"] != null)
                {
                    TextMessage objMsg = (TextMessage)Session["currentTextEmail"];
                    txtFromEmail.Text = objMsg.FromEmail;
                    txtSubject.Text = objMsg.Subject;
                    txtMsgName.Text = objMsg.MsgName;
                    txtMsgBody.Text = objMsg.MsgBody;
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            TextMessage objMsg = new TextMessage();
            objMsg.FromEmail = txtFromEmail.Text.Trim();
            objMsg.Subject = txtSubject.Text.Trim();
            objMsg.MsgName = txtMsgName.Text.Trim();
            objMsg.MsgBody = txtMsgBody.Text.Trim();
            objMsg.TypeMsg = 2;
            Session["currentTextEmail"] = objMsg;
            Response.Redirect("chooseEmailList.aspx");
        }

        protected void btnPopupSend_Click(object sender, EventArgs e)
        {
            ChilkatEmail.MailServices mailServices = new ChilkatEmail.MailServices();
            List<String> listMailTo = new List<string>();
            List<String> listMailCC = new List<string>();
            List<String> listMailBCC = new List<string>();
            String mailFrom = "";
            mailFrom = txtFromEmail.Text;
            listMailTo.Add(txtToEmail.Text);



            bool result = mailServices.SendHTMLEmail(mailFrom, listMailTo, listMailCC, listMailBCC, txtSubject.Text, txtMsgBody.Text);

            if (result)
            {
                string alertmessage = "This mail can send.";
                createHTMLEmail.CreateMessageAlert(this, alertmessage, "alertKey");
            }
        }

        public static void CreateMessageAlert(System.Web.UI.Page senderPage,
                      string alertMsg, string alertKey)
        {
            string strScript = "<script language=JavaScript>alert('" +
                               alertMsg + "')</script>";

            if (!(senderPage.IsStartupScriptRegistered(alertKey)))
                senderPage.RegisterStartupScript(alertKey, strScript);
        }

        protected void btnSpam_Click(object sender, EventArgs e)
        {
            CheckMail myAction = new CheckMail(CheckAction);
            //invoke it asynchrnously, control passes to next statement
            myAction.BeginInvoke(null, null);
        }

        void CheckAction()
        {
            SpamcheckServices spamcheck = new SpamcheckServices();
            spamcheck.SpamTextBeginChecking(txtFromEmail.Text);
            spamcheck.CheckSpamCompleted += new SpamcheckServices.XMLSpamPareCompletedEventHandler(spamcheck_CheckSpamCompleted);
        }
        void spamcheck_CheckSpamCompleted(float spamRawCore, float spamCoreDetail, String spamDescription, string spamDetailDescription)
        {
            if (spamRawCore > 4)
            {
                createHTMLEmail.CreateMessageAlert(this, "This is a spam", "alertKey");
            }
            else
            {
                createHTMLEmail.CreateMessageAlert(this, "this message is not spam", "alertKey");
            }
        }
    }
}