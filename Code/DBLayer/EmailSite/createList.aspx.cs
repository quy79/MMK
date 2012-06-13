using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseLayer;
namespace EmailSite
{
    public partial class createList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Utils.CheckSecurity(Session, Response);
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {            
            DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
            objList.USERID = Int32.Parse(Session["userID"].ToString());
            objList.LISTNAME = txtName.Text.Trim();
            objList.DESCRIPTION = txtDesc.Text.Trim();
            objList.NOTIFICATION = chkAgree.Checked;
            bool isOK = objList.Insert();
            if (isOK)
            {
                ClearForm();
                lblMsg.Text  = "          " + "The new list is added sucessfull." + "<br/>";
            }
            else lblMsg.Text = "          " + "The new list is added unsucessfull. Please try again!" + "<br/>";
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtDesc.Text = "";
        }
    }
}