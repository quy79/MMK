using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class editAutoresponder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = "";
                if (!IsPostBack)
                {
                    if (Request["id"] == null) lblMsg.Text = Utils.ShowMessage("Please choose a autoresponder to edit !", true);
                    else hdAutoID.Value = Int32.Parse(Request["id"].ToString()).ToString();
                    LoadData();
                }
                
            }
            catch { }
        }

        private void LoadData()
        {
            //DatabaseLayer 
            DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
            objList.USERID = Int32.Parse(Session["userID"].ToString());
            DataTable dtList = objList.SelectByUserID();
            ddlList.DataSource = dtList;
            ddlList.DataBind();

            DatabaseLayer.Autoresponder objAu = new DatabaseLayer.Autoresponder();
            objAu.ID = Int32.Parse(hdAutoID.Value);
            DataTable objDT = objAu.SelectByID();
            if (objDT != null && objDT.Rows.Count>0)
            {
                txtName.Text = objDT.Rows[0]["NAME"].ToString();
                txtDesc.Text = objDT.Rows[0]["DESCRIPTION"].ToString();
                txtFromName.Text = objDT.Rows[0]["FROMNAME"].ToString();
                txtFromEmail.Text = objDT.Rows[0]["FROMEMAIL"].ToString();
                txtDuration.Text = objDT.Rows[0]["DURATION"].ToString();
                ddlList.SelectedValue = objDT.Rows[0]["LISTID"].ToString();
            }

            //load list messages 
            DatabaseLayer.Autoresponder_messages objAuMsg = new DatabaseLayer.Autoresponder_messages();
            objAuMsg.AUTORESPONDERID = Int32.Parse(hdAutoID.Value);
            DataTable dtTable =  objAuMsg.SelectByAutoID();
            grvList.DataSource = dtTable;
            grvList.DataBind();
            if (dtTable != null && dtTable.Rows.Count > 0) pnlGrid.Visible = true;
            else pnlGrid.Visible = false;
        }

        protected void grvList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grvList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                try
                {
                    LinkButton l = (LinkButton)e.Row.FindControl("LinkDelete");
                    l.Attributes.Add("onclick", "javascript:return " +
                    "confirm('Are you sure you want to delete this list? ')");

                    Button bn = (Button)e.Row.FindControl("btnStartStop");
                    Label lb = (Label)e.Row.FindControl("lblStatus");
                        
                    //
                    DataRowView dataRow = (DataRowView)e.Row.DataItem;
                    int hasStart = Int32.Parse(dataRow["HASSTART"].ToString());
                    int msgStatus = Int32.Parse(dataRow["MSGSTATUS"].ToString());
                    if (msgStatus == 2) // start
                    {
                        bn.Text = "Stop";
                        bn.CommandName = "Stop";
                        bn.Enabled = true;
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
                        lb.Text = "<span id=\"status_003\" class=\"sending_status_completed\">" + percent .ToString()+ "% completed</span>";
                        if (hasStart >= 1)
                        {
                            bn.Text = "Start";
                            bn.CommandName = "Start";
                            bn.Enabled = false;
                        }
                        else
                        {
                            bn.Text = "Start";
                            bn.CommandName = "Start";
                            bn.Enabled = true;
                        }
                    }
                   // HASSTART
                    
                }
                catch { }
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

            if (e.CommandName == "Stop")
            {

                int msgID = Convert.ToInt32(e.CommandArgument);
                DatabaseLayer.Autoresponder_messages obj = new DatabaseLayer.Autoresponder_messages();
                obj.MESSAGEID = msgID;
                obj.STATUS = 0;
                obj.UpdateStatusForMsg();
                LoadData();
            }

            if (e.CommandName == "Start")
            {

                int msgID = Convert.ToInt32(e.CommandArgument);
                DatabaseLayer.Autoresponder_messages obj = new DatabaseLayer.Autoresponder_messages();
                obj.MESSAGEID = msgID;
                obj.STATUS = 2;
                obj.UpdateStatusForMsg();

                LoadData();
            }

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
                objAuto.ID = Int32.Parse(hdAutoID.Value);
                objAuto.USERID = Int32.Parse(Session["userID"].ToString());
                objAuto.NAME = txtName.Text.Trim();
                objAuto.DESCRIPTION = txtDesc.Text.Trim();
                objAuto.FROMNAME = txtFromName.Text.Trim();
                objAuto.FROMEMAIL = txtFromEmail.Text.Trim();
                objAuto.DURATION = Int32.Parse(txtDuration.Text.Trim());
                objAuto.LISTID = Int32.Parse(ddlList.SelectedValue.ToString());

                bool isUpdate = objAuto.Update();
                if (isUpdate) lblMsg.Text = Utils.ShowMessage("Autoresponder was successful updated.", false);
                else lblMsg.Text = Utils.ShowMessage("Autoresponder was unsuccessful updated. Please try again !", true);               
            }
            catch { }
        }

        protected void grvList_DataBound(object sender, EventArgs e)
        {
            
          

        }
    }
}