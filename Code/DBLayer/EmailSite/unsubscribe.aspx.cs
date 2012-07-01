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
            int contact = 0;
            int listID = 0;
            String url = "";
            if (context.Request.Params["CONTACTID"] != null)
            {
                try
                {
                    contact = int.Parse(context.Request.Params["CONTACTID"]);
                }
                catch
                {
                    contact = 0;
                }
            }

            if (context.Request.Params["LISTID"] != null)
            {
                try
                {
                    listID = int.Parse(context.Request.Params["LISTID"]);
                }
                catch
                {
                    listID = 0;
                }
            }
           // if (context.Request.Params["REDIRECTURL"] != null)

                if (contact > 0)
                {

                    Contact_list ct = new Contact_list();
                    ct.LISTID = listID;
                    ct.CONTACTID = contact;
                    DataTable dt = ct.Select();
                    ct.SUBSCRIBES = false;


                    ct.Update();
                }
            //context.Response.Redirect(url);

            // context.Response.End();
            //return;

        }
    }
}