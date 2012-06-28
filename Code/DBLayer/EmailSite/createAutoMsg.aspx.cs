using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class createAutoMsg : System.Web.UI.Page
    {

        public string strListName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Utils.CheckSecurity(Session, Response);
                if (!IsPostBack)
                {
                    if (Request["Aid"] != null) hdAutoID.Value = Request["Aid"];
                    else hdAutoID.Value = "0";

                    LoadData();
                }
            }
            catch { }
            
        }

        private void LoadData()
        {
            DatabaseLayer.Autoresponder objList = new DatabaseLayer.Autoresponder();
            objList.ID = Int32.Parse(hdAutoID.Value);
            DataTable objDT = objList.SelectByID();
            if (objDT != null) strListName = objDT.Rows[0]["NAME"].ToString();

            DatabaseLayer.Autoresponder_messages objAuMsg = new DatabaseLayer.Autoresponder_messages();
            objAuMsg.AUTORESPONDERID = Int32.Parse(hdAutoID.Value);
            DataTable dtTable = objAuMsg.SelectByAutoID();
            grvList.DataSource = dtTable;
            grvList.DataBind();
            if (dtTable != null && dtTable.Rows.Count > 0) pnlGrid.Visible = true;
            else pnlGrid.Visible = false;
        }

        protected void grvList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton l = (LinkButton)e.Row.FindControl("LinkDelete");
                l.Attributes.Add("onclick", "javascript:return " +
                "confirm('Are you sure you want to delete this list? ')");

                Label lb = (Label)e.Row.FindControl("lblStatus");

                //
                DataRowView dataRow = (DataRowView)e.Row.DataItem;
                int hasStart = Int32.Parse(dataRow["HASSTART"].ToString());
                int msgStatus = Int32.Parse(dataRow["MSGSTATUS"].ToString());
                if (msgStatus == 2) // start
                {
                    lb.Text = "<span id=\"status_002\" class=\"sending_status\">sending...</span>";
                }
                else
                {
                    int totalcontact = Int32.Parse(dataRow["TOTALCONTACT"].ToString());
                    int contactsend = Int32.Parse(dataRow["SUMCONTACTSENT"].ToString());
                    int percent = 0;
                    if (totalcontact != 0)
                    {
                        percent = (contactsend / totalcontact) * 100;
                    }
                    if (percent < 0 || percent > 100) percent = 0;
                    lb.Text = "<span id=\"status_003\" class=\"sending_status_completed\">" + percent.ToString() + "% completed</span>";
                    
                }
            }
        }

        protected void grvList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DelItem")
            {

                int listID = Convert.ToInt32(e.CommandArgument);
                //delete all records in contact_list
                //DatabaseLayer.Contact_list contlist = new DatabaseLayer.Contact_list();
                //contlist.LISTID = listID;
                //contlist.Delete();
                ////delete in List;
                //DatabaseLayer.Lists list = new DatabaseLayer.Lists();
                //list.ID = listID;
                //list.Delete();
                //LoadData();
            }

        }

        protected void lnkTextMail_Click(object sender, EventArgs e)
        {
            if (hdAutoID.Value != "0") Response.Redirect("createAutoTextEmail.aspx?Aid=" + hdAutoID.Value);
            else Response.Redirect("createAutoTextEmail.aspx");
        }


        protected void lnkHTMLMail_Click(object sender, EventArgs e)
        {
            if (hdAutoID.Value != "0") Response.Redirect("createAutoHTMLEmail.aspx?Aid=" + hdAutoID.Value);
            else Response.Redirect("createAutoHTMLEmail.aspx");
        }

      

       
    }
}