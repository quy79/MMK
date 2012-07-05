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
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            int contactID = 0;
            int listID = 0;
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
            if (String.IsNullOrEmpty(param))
            {
                //"CONTACTID=" + contactID + "&LISTID=" + listID + "&REDIRECTURL=Unsubscribe";
                param = param.Substring(0, param.Length - 1);
                String paremdecode = Decode(param);
                String[] temp = paremdecode.Split('&');
                String _contactID = temp[0].Split('=')[1];
             
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
                if (contactID > 0 && listID>0)
                {
                    Contact_list ct = new Contact_list();
                    ct.LISTID = listID;
                    ct.CONTACTID = contactID;
                    DataTable dt = ct.Select();
                    ct.SUBSCRIBES = false;
                    ct.Update();
                }
            }

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
    }
}