using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseLayer;
using System.Data;
namespace EmailSite
{
    public partial class unsubscribe : System.Web.UI.Page
    {
        int contactID = 0;
        int listID = 0;
        string email = "";
        protected void Page_Load1(object sender, EventArgs e)
        {
            
            int autoID = 0;
            int messageID = 0;
            int listID = 0;
            HttpContext context = HttpContext.Current;
            // Encode("AUTORESPONDERID=" + autoresponderID + "&MESSAGEID=" + messageID + "&LISTID=" + listID)
            //empty.jpg?paramcode=QVVUT1JFU1BPTkRFUklEPTMmTUVTU0FHRUlEPTImTElTVElEPTMy


             String param = "";
            if (context.Request.Params["paramcode"] != null)
            {
                try
                {
                    param = (String)context.Request.Params["paramcode"];
                }
                catch
                {
                    param = "";
                }
            }
            if (!String.IsNullOrEmpty(param))
            {
                // Encode("AUTORESPONDERID=" + autoresponderID + "&MESSAGEID=" + messageID + "&LISTID=" + listID + "&REDIRECTURL=" + link.Replace("\"", "") + "'");
                // param = param.Substring(0, param.Length - 1);
                String paremdecode = Decode(param);
                String[] temp = paremdecode.Split('&');
                String _autoD = temp[0].Split('=')[1];

                String _mesageID = temp[1].Split('=')[1];
                String _listID = temp[2].Split('=')[1];
                // String url = temp[3].Split('=')[1];
                try
                {
                    autoID = int.Parse(_autoD);
                }
                catch
                {
                    autoID = 0;
                }
                try
                {
                    messageID = int.Parse(_mesageID);
                }
                catch
                {
                    messageID = 0;
                }

                try
                {
                    listID = int.Parse(_listID);
                }
                catch
                {
                    listID = 0;
                }



                if (autoID > 0)
                {
                     ClickOpenStatus obj = new ClickOpenStatus();
                    obj.AUTORESPONDERID = autoID;
                    obj.MESSAGEID = messageID;
                    obj.LISTID = listID;
                    int countclick = 0;
                    int countopen = 0;
                    DataTable dt = obj.Select();
                    bool newItem = true;
                    if (dt != null && dt.Rows.Count > 0)
                    {                   
                        DataRow row = dt.Rows[0];
                        countclick = int.Parse(row[4].ToString());
                        countopen = int.Parse(row[5].ToString());
                        newItem = false;
                    }
                    if (newItem)
                    {
                        obj.COUNTCLICK = 0;
                        obj.COUNTOPEN = 1;
                        obj.Insert();
                    }
                    else
                    {
                        obj.COUNTCLICK = countclick;
                        obj.COUNTOPEN = countopen + 1;
                        obj.Update();
                    }
                }
                
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //return;
            HttpContext context = HttpContext.Current;
            //int contactID = 0;
            //int listID = 0;
            String param = "";
            if (context.Request.Params["paramcode"] != null)
            {
                try
                {
                    param = (String)context.Request.Params["paramcode"];
                }
                catch
                {
                    param = "";
                }
            }
            if (!String.IsNullOrEmpty(param))
            {
                //"CONTACTID=" + contactID + "&LISTID=" + listID + "&REDIRECTURL=Unsubscribe";
                // param = param.Substring(0, param.Length - 1);
                try
                {
                    String paremdecode = Decode(param);
                    String[] temp = paremdecode.Split('&');
                    String _contactID = temp[0].Split('=')[1];
                    String _email = temp[2].Split('=')[1];
                    String _listID = temp[1].Split('=')[1];
                    try
                    {
                        contactID = int.Parse(_contactID);
                    }
                    catch
                    {
                        contactID = 0;
                    }

                    try
                    {
                        listID = int.Parse(_listID);
                    }
                    catch
                    {
                        listID = 0;
                    }

                    email = _email;
                }
                catch (Exception eee)
                {
                }

            }

            txtUsername.Text = email;


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Decode(string str)
        {
            byte[] decbuff = Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(decbuff);
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //String patamcode = Encode("CONTACTID=" + 12 + "&LISTID=" + 12+"&EMAIL="+"ndhieuvn212@yahoo.com");
           // String replaceString = "'" + "serverName" + "/unsubscribe.aspx?paramcode=" + patamcode + "' ";
            if (contactID > 0 && listID > 0)
            {
                Contact_list ct = new Contact_list();
                ct.LISTID = listID;
                ct.CONTACTID = contactID;
                DataTable dt = ct.Select();
                ct.SUBSCRIBES = false;
                bool rs = ct.Update();
                if (rs)
                {
                    errorMessage.Text = "Your email has been unsubscribed successfully";
                }
                else
                {
                    errorMessage.Text = "Error: not found your email in the system.";
                }
            }
        }
        public string Encode(string str)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(encbuff);
        }
    }
}