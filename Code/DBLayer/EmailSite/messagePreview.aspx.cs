using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class messagePreview : System.Web.UI.Page
    {
        public string strContent = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Utils.CheckSecurity(Session, Response);
                if (Session["currentTextEmail"] != null)
                {
                    TextMessage objMsg = (TextMessage)Session["currentTextEmail"];
                    strContent = objMsg.MsgBody;


                    //lblMsgBody.Text = objMsg.MsgBody;
                }
            }
            catch { }
        }
    }
}