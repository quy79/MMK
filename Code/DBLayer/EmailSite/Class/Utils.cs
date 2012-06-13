using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public static class Utils
    {
        public static void CheckSecurity(System.Web.SessionState.HttpSessionState Session, System.Web.HttpResponse Response)         
        {
            if (Session["username"] == null) Response.Redirect("login.aspx");
        }
    }

    public class TextMessage
    {
        public string FromEmail;
        public string Subject;
        public string MsgName;
        public string MsgBody;
        public int ListID;
        public int TypeMsg = 1;
    }
}