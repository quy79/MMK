﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ChilkatEmail;

using ChilkatEmail.Utils;
namespace EmailSite
{
    public partial class createTextEmail : System.Web.UI.Page
    {
       
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
            objMsg.TypeMsg = 1;

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
          


            bool result = mailServices.SendEmail(mailFrom, listMailTo, listMailCC, listMailBCC, txtSubject.Text, txtMsgBody.Text);

            if (result) lblMsg.Text = Utils.ShowMessage("This mail can send.", false);
            else lblMsg.Text = Utils.ShowMessage("This mail cannot send.", true);
                
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