using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class uploadContacts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack) LoadData();
        }

        private void LoadData()
        {
            DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
            objList.USERID = Int32.Parse(Session["userID"].ToString());
            DataTable dtList = objList.SelectByUserID();
            rptList.DataSource = dtList;
            rptList.DataBind();
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
           string strListSelected = Request["listContact"];
           if (!strListSelected.Equals(""))
           {
               Stream theStream = file.PostedFile.InputStream;
               using (StreamReader sr = new StreamReader(theStream))
               {
                   string line;
                   while ((line = sr.ReadLine()) != null)
                   {
                       string email = "";
                       int iPos = line.IndexOf(',');
                       if (iPos > 0) email = line.Substring(0, iPos - 1);
                       else email = line;

                       DatabaseLayer.Contacts objContact = new DatabaseLayer.Contacts();
                       objContact.EMAIL = email;

                       objContact.PREFIX = "";
                       objContact.LASTNAME = "";
                       objContact.FIRSTNAME = "";
                       objContact.SUFFIX = "";

                       objContact.ADDRESS1 = "";
                       objContact.ADDRESS2 = "";

                       objContact.CITY = "";
                       objContact.PROVINCE = "";
                       objContact.ZIP = "";

                       objContact.BUSINESSNAME = "";
                       objContact.PHONE = "";
                       objContact.FAX = "";

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

                       if (objContact.IsExistContactEmail()) continue;

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
                               objContactList.SUBSCRIBES = false;

                               objContactList.Insert();

                           }
                          
                       }
                      

                   }
               }
           }
           else
           {
               lblMsg.Text = "Please select aleast 1 list.<br/>";
           }
        }

    }

}
