﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class previewEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Utils.CheckSecurity(Session, Response);
            if (!IsPostBack) LoadData();
        }

        private void LoadData()
        {
            if (Session["currentTextEmail"] != null)
            {
                TextMessage objMsg = (TextMessage)Session["currentTextEmail"];
                lblFrom.Text = objMsg.FromEmail;
                lblSubject.Text = objMsg.Subject;
                lblMsgName.Text = objMsg.MsgName;

                DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
                objList.ID = objMsg.ListID;
                System.Data.DataTable dbTable =  objList.SelectByID();
                if (dbTable.Rows.Count > 0) lblListName.Text = dbTable.Rows[0]["LISTNAME"].ToString();

                //lblMsgBody.Text = objMsg.MsgBody;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //clear session
            Session["currentTextEmail"] = null;
            Response.Redirect("createMsgDone.aspx");
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (Session["currentTextEmail"] != null)
            {
                TextMessage objMsg = (TextMessage)Session["currentTextEmail"];


                DatabaseLayer.Contact_list objCList = new DatabaseLayer.Contact_list();
                objCList.LISTID = objMsg.ListID;
                System.Data.DataTable dbTable = objCList.SelectByListID();
                //if (dbTable.Rows.Count > 0) lblListName.Text = dbTable.Rows[0]["LISTNAME"].ToString();

                ChilkatEmail.MailServices mailServices = new ChilkatEmail.MailServices();
                List<String> listMailTo = new List<string>();
                List<String> listMailCC = new List<string>();
                List<String> listMailBCC = new List<string>();
                String mailFrom = "";
                mailFrom = objMsg.FromEmail;
                if (dbTable.Rows.Count > 0)
                {
                    foreach (System.Data.DataRow row in dbTable.Rows)
                    {
                        string emailContact = row["EMAIL"].ToString();
                        listMailTo.Add(emailContact);
                    }
                }
                //listMailTo.Add(txtToEmail.Text);


                if (objMsg.TypeMsg == 1) mailServices.SendEmail(mailFrom, listMailTo, listMailCC, listMailBCC, objMsg.Subject, objMsg.MsgBody);
                else
                 mailServices.SendHTMLEmail(mailFrom, listMailTo, listMailCC, listMailBCC, objMsg.Subject, objMsg.MsgBody);

                //lblMsgBody.Text = objMsg.MsgBody;
            }
        }
    }
}