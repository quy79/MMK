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

        public static string ShowMessage(string msg, bool isError)
        {
            string strMsg = "<div class=\"create-message-step1-container3\"><div class=\"infobox3\">"+msg+"</div></div>";
            if (isError) strMsg = "<div class=\"create-message-step1-container3\"><div class=\"infobox4\">Error :<br/><div style=\"clear: both; height: auto; position: relative; color: red; font-size: 13px;\">" + msg + "</div></div></div>";
            return strMsg;
        }
    }

    public class TextMessage
    {
        public string FromEmail;
        public string Subject;
        public string MsgName;
        public string MsgBody;
        public int ListID;
        public bool IsSegment;
        public int TypeMsg = 1;
    }
}