using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrMsg.Text = "";
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            int i = UserDB.AddUser(txtFirstname.Text.Trim(), txtLastname.Text.Trim(), txtUsername.Text.Trim(),
                                   txtPassword.Text.Trim(), txtEmail.Text.Trim(), txtPhone.Text.Trim(), txtCompany.Text.Trim());

            switch (i)
            {
                case 0:
                    lblErrMsg.Text = "Your registration attempt was unsuccessful. Please try again ! ";
                    break;
                case 1:
                    ClearForm();
                    lblErrMsg.Text = "Your registration attempt was successful.";
                    break;
                case 2:
                    lblErrMsg.Text = "This Email address has been used. Please try again.";
                    break;
                case 3:
                    lblErrMsg.Text = "This Username has been used. Please try again.";
                    break;
                default:
                    break;
            }
        }

        private void ClearForm()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtCompany.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
        }
    }
}