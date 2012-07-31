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
       // int listID = 0;
        string email = "";
        
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
                    String _email = temp[1].Split('=')[1];
                   // String _listID = temp[1].Split('=')[1];
                    try
                    {
                        contactID = int.Parse(_contactID);
                    }
                    catch
                    {
                        contactID = 0;
                    }

                   /* try
                    {
                        listID = int.Parse(_listID);
                    }
                    catch
                    {
                        listID = 0;
                    }
                    */
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
            if (contactID > 0 )
            {
                Contact_list ct = new Contact_list();
               // ct.LISTID = listID;
                ct.CONTACTID = contactID;
                DataTable dt = ct.Select();
                ct.SUBSCRIBES = false;
                bool rs = ct.RemoveOutList();
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