using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class createMsgDone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Utils.CheckSecurity(Session, Response);
                int listID = Int32.Parse(Request["listid"]);
                DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
                objList.ID = listID;
                DataTable dt = objList.SelectByID();
                lblListName.Text = dt.Rows[0]["LISTNAME"].ToString();
            }
            catch { }
        }
    }
}