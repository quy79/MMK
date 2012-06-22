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
            string strListSelected = Request["listContact"];
            if (!strListSelected.Equals(""))
            {
                DatabaseLayer.Contacts objContact = new DatabaseLayer.Contacts();
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

                if (chkAgree.Checked)
                {
                    objContact.CONFIRMED = false;
                    objContact.SENDEMAIL = false;
                    objContact.CONFIRMCODE = Guid.NewGuid().ToString().Replace("-", "");
                }
                else
                {
                    objContact.CONFIRMED = true;
                    objContact.SENDEMAIL = true;
                    objContact.CONFIRMCODE = Guid.NewGuid().ToString().Replace("-", "");
                }
                if (objContact.IsExistContactEmail())
                {
                    lblMsg.Text = "This email has been registered. <br/>";
                    return;
                }

                int iContactID = objContact.Insert();
                if (iContactID > 0)
                {
                    //insert contact_list
                    string[] listIDs = strListSelected.Split(',');
                    foreach (string strID in listIDs)
                    {
                        DatabaseLayer.Contact_list objContactList = new DatabaseLayer.Contact_list();
                        objContactList.CONTACTID = iContactID;
                        objContactList.LISTID = Int32.Parse(strID);
                        objContactList.SUBSCRIBES = true;

                        objContactList.Insert();

                    }
                    ClearForm();
                    lblMsg.Text = "The new contact is added sucessfull. <br/>";
                }
                else {
                    lblMsg.Text = "The new contact is added unsucessfull. Please try again ! <br/>";
                }
            }
            else
            {
                lblMsg.Text = "Please select aleast 1 list <br/>";
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