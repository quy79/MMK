using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class navigation : System.Web.UI.UserControl
    {
        public string MenuType = "home";//home, emails, contacts, reports
        public string strHomeSelected = "selected";
        public string strEmailSelected = "";
        public string strContactSelected = "";
        public string strReportSelected = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            strHomeSelected = (MenuType.Equals("home")) ? "selected" : "";
            strEmailSelected = (MenuType.Equals("emails")) ? "selected" : "";
            strContactSelected = (MenuType.Equals("contacts")) ? "selected" : "";
            strReportSelected = (MenuType.Equals("reports")) ? "selected" : "";
        }
        
    }
}