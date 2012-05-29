using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class logo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null) lblUsername.Text = (string)Session["username"];
            else Response.Redirect("timeout.aspx");
        }
    }
}