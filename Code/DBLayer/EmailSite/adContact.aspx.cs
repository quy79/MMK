using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class adContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Utils.CheckSecurity(Session, Response);
            if (Request.QueryString["listid"]!=null && !Request.QueryString["listid"].Equals(""))
                listsDiv.Visible = false;
            lblMsg.Text = "";
            if(!Page.IsPostBack) LoadData();
        }

        private void LoadData()
        {
            DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
            objList.USERID = Int32.Parse(Session["userID"].ToString());
            DataTable dtList = objList.SelectByUserID();
            rptList.DataSource = dtList;
            rptList.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            string strListSelected;
            if (Request.QueryString["listid"] == null || Request.QueryString["listid"].Equals(""))
                strListSelected = Request["listContact"];
            else
                strListSelected = Request.QueryString["listid"];


            System.Web.UI.HtmlControls.HtmlGenericControl noticeContentDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            noticeContentDiv.ID = "infoDivCode";
            noticeContentDiv.Style.Add("position", "relative");
            noticeContentDiv.Style.Add("margin", "20px auto");
            noticeContentDiv.Style.Add("padding", "20px 0px 0px 80px");
            noticeContentDiv.Style.Add("width", "520px");
            noticeContentDiv.Style.Add("height", "40px");
            noticeContentDiv.Style.Add("color", "#000000");
            noticeContentDiv.Style.Add("background-color", "#fbf6d7");
            noticeContentDiv.Style.Add("border", "1px solid #0b5d91");
            noticeContentDiv.Style.Add("-moz-border-radius", "6px 6px 6px 6px");
            noticeContentDiv.Style.Add("border-radius", "6px 6px 6px 6px");
            noticeContentDiv.Style.Add("-webkit-border-radius", "6px 6px 6px 6px");
            noticeContentDiv.Style.Add("background-repeat", "no-repeat");
            noticeContentDiv.Style.Add("background-position", "10px center");
            noticeContentDiv.Style.Add("font-size", "13px");
            noticeContentDiv.Style.Add("font-weight", "500");
            noticeContentDiv.Style.Add("text-align", "left");
            noticeContentDiv.Style.Add("clear", "both");


            if (strListSelected != null)
            {
                DatabaseLayer.Contacts objContact = new DatabaseLayer.Contacts();
                objContact.USERID = Int32.Parse(Session["userID"].ToString());
                objContact.EMAIL = txtEmail.Text.Trim();

                objContact.PREFIX = txtPrefix.Text.Trim();
                objContact.LASTNAME = txtLastname.Text.Trim();
                objContact.FIRSTNAME = txtFirstname.Text.Trim();
                objContact.SUFFIX = txtSuffix.Text.Trim();

                objContact.ADDRESS1 = txtAddr1.Text.Trim();
                objContact.ADDRESS2 = txtAddr2.Text.Trim();

                objContact.CITY = txtCity.Text.Trim();
                objContact.PROVINCE = txtState.Text.Trim();
                objContact.ZIP = txtZip.Text.Trim();

                objContact.BUSINESSNAME = txtBusinessname.Text.Trim();
                objContact.PHONE = txtPhone.Text.Trim();
                objContact.FAX = txtFax.Text.Trim();


                objContact.CONFIRMED = true;
                objContact.SENDEMAIL = true;
                objContact.CONFIRMCODE = Guid.NewGuid().ToString().Replace("-", "");
        

                int iContactID = objContact.IsExistContactEmail();
                if (iContactID > 0)
                {
                    
                    noticeContentDiv.Style.Add("background-image", "url(../../img/error.png)");
                    noticeContentDiv.InnerHtml = "Error : This Email Address already existed in the Contact List !";
                    infoDiv.Controls.Add(noticeContentDiv);
                    pnlAddMore.Visible = true;
                    return;
                }
                else {

                    iContactID = objContact.Insert();

                    if (iContactID > 0)
                    {
                        //insert contact_list
                        string[] listIDs;
                        if (Request.QueryString["listid"]==null || Request.QueryString["listid"].Equals(""))
                        {
                            listIDs = strListSelected.Split(',');
                        }
                        else
                        {
                            listIDs = new string[1];
                            listIDs[0] = Request.QueryString["listid"];
                        }


                        foreach (string strID in listIDs)
                        {
                            DatabaseLayer.Contact_list objContactList = new DatabaseLayer.Contact_list();
                            objContactList.CONTACTID = iContactID;
                            objContactList.LISTID = Int32.Parse(strID);
                            objContactList.SUBSCRIBES = true;
                            int isDuplicate = 0;

                            isDuplicate = objContactList.CheckDuplicateContact();
                            if (isDuplicate == 0) objContactList.Insert();


                        }


                        //update total subscribes in contact list table
                        string[] listIDs1;
                        if (Request.QueryString["listid"]==null || Request.QueryString["listid"].Equals(""))
                        {
                            listIDs1 = strListSelected.Split(',');
                        }
                        else
                        {
                            listIDs1 = new string[1];
                            listIDs1[0] = Request.QueryString["listid"];
                        }

                        foreach (string strID in listIDs1)
                        {
                            DatabaseLayer.Contact_list objContactList = new DatabaseLayer.Contact_list();
                            objContactList.LISTID = Int32.Parse(strID);
                            DataTable dt = objContactList.SelectByListID();
                            int totalSubscribes = dt.Rows.Count;

                            DatabaseLayer.Lists objList1 = new DatabaseLayer.Lists();
                            objList1.USERID = Int32.Parse(Session["userID"].ToString());
                            objList1.ID = Int32.Parse(strID);
                            objList1.TOTALSUBSCRIBES = totalSubscribes;
                            objList1.UpdateTotalSubscribers();


                        }



                        ClearForm();


                        noticeContentDiv.Style.Add("background-image", "url(../../img/check.png)");
                        noticeContentDiv.InnerHtml = "Contact is successful saved.";
                        infoDiv.Controls.Add(noticeContentDiv);
                        pnlAddMore.Visible = true;

                    }
                    else
                    {
                        noticeContentDiv.Style.Add("background-image", "url(../../img/error.png)");
                        noticeContentDiv.InnerHtml = "Error : Failed to add Contact !";
                        infoDiv.Controls.Add(noticeContentDiv);
                    }
                    
                
                }

                
            }
            else
            {
                noticeContentDiv.Style.Add("background-image", "url(../../img/error.png)");
                noticeContentDiv.InnerHtml = "Please select at least 1 list.";
                infoDiv.Controls.Add(noticeContentDiv);
            }
        }

        private void ClearForm()
        {
            txtEmail.Text = "";

            txtPrefix.Text = "";
            txtLastname.Text = "";
            txtFirstname.Text = "";
            txtSuffix.Text = "";

            txtAddr1.Text = "";
            txtAddr2.Text = "";

            txtCity.Text = "";
            txtState.Text = "";
            txtZip.Text = "";

            txtBusinessname.Text = "";
            txtPhone.Text = "";
            txtFax.Text = "";
        }

       

    }
}