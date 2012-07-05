using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class createAutoTemplateEmail : System.Web.UI.Page
    {
        public string strListName = "";
        public string strAutoresponderID = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Utils.CheckSecurity(Session, Response);
                if (!IsPostBack)
                {
                    if (Request["Aid"] != null) hdAutoID.Value = Request["Aid"];
                    else hdAutoID.Value = "0";
                    strAutoresponderID = hdAutoID.Value;
                    DatabaseLayer.Autoresponder objList = new DatabaseLayer.Autoresponder();
                    objList.ID = Int32.Parse(hdAutoID.Value);
                    DataTable objDT = objList.SelectByID();
                    if (objDT != null) strListName = objDT.Rows[0]["NAME"].ToString();
                }
            }
            catch { }
        }
    }
}