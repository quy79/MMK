using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class createAutoresponder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Utils.CheckSecurity(Session, Response);
                if (!IsPostBack)
                {
                    LoadContactLists();
                }
                lblMsg.Text = "";
            }
            catch { }
        }

        private void LoadContactLists()
        {
            //DatabaseLayer 
            DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
            objList.USERID = Int32.Parse(Session["userID"].ToString());
            DataTable dtList = objList.SelectListsAndSegmentsByUserID();
            ddlList.DataSource = dtList;
            ddlList.DataBind();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlList.SelectedItem == null)
                {
                    lblMsg.Text = Utils.ShowMessage("Please choose select a list to create autoresponder.", true);
                    return;
                }

                try { Int32.Parse(txtDuration.Text.Trim()); }
                catch
                {
                    lblMsg.Text = Utils.ShowMessage("Interval of Autoresponder must be a integer greater than 1.", true);
                    return;
                }

                DatabaseLayer.Autoresponder objAuto = new DatabaseLayer.Autoresponder();
                objAuto.USERID = Int32.Parse(Session["userID"].ToString());
                objAuto.NAME = txtName.Text.Trim();
                objAuto.DESCRIPTION = txtDesc.Text.Trim();
                objAuto.FROMNAME = txtFromName.Text.Trim();
                objAuto.FROMEMAIL = txtFromEmail.Text.Trim();
                objAuto.DURATION = Int32.Parse(txtDuration.Text.Trim());
                objAuto.LISTID = Int32.Parse(ddlList.SelectedValue.ToString().Substring(1));
                if (ddlList.SelectedValue[0] == 'L') objAuto.ISSEGMENT = false;
                else objAuto.ISSEGMENT = true;

                int newID = objAuto.Insert();
                if(newID>0) Response.Redirect("myAutoresponders.aspx");
            }
            catch { }
             
        }
    }
}