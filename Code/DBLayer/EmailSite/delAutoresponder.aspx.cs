using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class delAutoresponder : System.Web.UI.Page
    {
        public string strListName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Utils.CheckSecurity(Session, Response);
                if (!IsPostBack)
                {
                    if (Request["id"] != null) hdAutoID.Value = Request["id"];
                    else hdAutoID.Value = "0";

                    LoadData();
                }
            }
            catch { }

        }

        private void LoadData()
        {
            DatabaseLayer.Autoresponder objAu = new DatabaseLayer.Autoresponder();
            objAu.ID = Int32.Parse(hdAutoID.Value);
            DataTable objDT = objAu.SelectByID();
            if (objDT != null && objDT.Rows.Count > 0)
            {
                lblName.Text = objDT.Rows[0]["NAME"].ToString();
                lblDescription.Text = objDT.Rows[0]["DESCRIPTION"].ToString();
                lblFromName.Text = objDT.Rows[0]["FROMNAME"].ToString();
                lblFromEmail.Text = objDT.Rows[0]["FROMEMAIL"].ToString();
                lblInterval.Text = objDT.Rows[0]["DURATION"].ToString() + " days";
                //ddlList.SelectedValue = objDT.Rows[0]["LISTID"].ToString();
            }

          
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
           

        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            DatabaseLayer.Autoresponder objAuto = new DatabaseLayer.Autoresponder();
            objAuto.ID = Int32.Parse(hdAutoID.Value);
            if (objAuto.Delete()) Response.Redirect("myAutoresponders.aspx");
            else
            {

            }

        }

  
    }
}