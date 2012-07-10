using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class addContacts : System.Web.UI.Page
    {
        protected string listid;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Utils.CheckSecurity(Session, Response);
                listid = (Request.QueryString["listid"] == null) ? "" : "?listid=" + Request.QueryString["listid"];
            }
            catch { }
        }
    }
}