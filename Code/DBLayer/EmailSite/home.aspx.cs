using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //check security
            if(Session["username"]==null) Response.Redirect("login.aspx");
           // navigation.MenuType = "home";
        }
    }
}