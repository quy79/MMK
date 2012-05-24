using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrMsg.Text = "";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserDB.CheckUserPass(txtUsername.Text.Trim(), txtPassword.Text.Trim()))
            {
                Session["username"] = txtUsername.Text.Trim();
                Response.Redirect("index.aspx");
            }
            else lblErrMsg.Text = "Username and password are not correct !";
        }
    }
}