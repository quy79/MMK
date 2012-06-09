using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChilkatEmail;

namespace EmailSite.Test
{
    public partial class TestSendMailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

    

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            MailServices mailServices = new MailServices();
            List<String> listMailTo = new List<string>();
            List<String> listMailCC = new List<string>();
            List<String> listMailBCC = new List<string>();
            String mailFrom = "";
            mailFrom = "ndhieuvn212@yahoo.com";
            listMailTo.Add("ndhieuvn212@yahoo.com");
            listMailCC.Add("ndhieuvn212@yahoo.com");
            listMailCC.Add("quy@optlynx.com");
            listMailCC.Add("quy79vn@gmail.com");
            listMailCC.Add("lequangquy@yahoo.com");
            listMailCC.Add("quy792006@yahoo.co.jp");
            listMailCC.Add("lequangquy@ezweb.ne.jp");
            listMailCC.Add("quy792006@yahoo.co.jp");
            listMailCC.Add("hoangphucnguyen@yahoo.com");


            bool result = mailServices.SendHTMLEmail(mailFrom,listMailTo,listMailCC,listMailBCC,"subject", Request.Form["elm1"]);
            if (result)
            {
                string alertmessage = "This mail can send.";
                TestMail.CreateMessageAlert(this, alertmessage, "alertKey");
            }
        }
        public static void CreateMessageAlert(System.Web.UI.Page senderPage,
                      string alertMsg, string alertKey)
        {
            string strScript = "<script language=JavaScript>alert('" +
                               alertMsg + "')</script>";

            if (!(senderPage.IsStartupScriptRegistered(alertKey)))
                senderPage.RegisterStartupScript(alertKey, strScript);
        }
    }
}