using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class editSegment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Utils.CheckSecurity(Session, Response);
                if (!IsPostBack)
                {
                    if (Request["id"] == null) lblMsg.Text = "Please choose a segment to edit !";
                    else hdSegmentID.Value = Int32.Parse(Request["id"].ToString()).ToString();
                    LoadData();
                }
                lblMsg.Text = "";
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

            
            //load segment by ID
            DatabaseLayer.Segment objSeg = new DatabaseLayer.Segment();
            objSeg.ID = Int32.Parse(hdSegmentID.Value);
            DataTable dtTable = objSeg.SelectBySegmentID();
            if (dtTable != null)
            {
                txtName.Text = dtTable.Rows[0]["NAME"].ToString();
                txtDesc.Text = dtTable.Rows[0]["DESCRIPTION"].ToString();
                ddlList.Items.FindByValue(dtTable.Rows[0]["LISTID"].ToString()).Selected = true;
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //validation data
                if (txtName.Text.Trim().Length == 0)
                {
                    lblMsg.Text = "Please enter Segment Name";
                    return;
                }

                if (ddlList.Items.Count == 0)
                {
                    lblMsg.Text = "Please choose a List to create segment.";
                    return;
                }
                DatabaseLayer.Segment objSegment = new DatabaseLayer.Segment();
                objSegment.ID = Int32.Parse(hdSegmentID.Value);
                objSegment.USERID = Int32.Parse(Session["userID"].ToString());
                objSegment.NAME = txtName.Text.Trim();
                objSegment.DESCRIPTION = txtDesc.Text.Trim();
                objSegment.LISTID = Int32.Parse(ddlList.SelectedValue);


                if (objSegment.Update()) Response.Redirect("addSegementCriterias.aspx?id=" + hdSegmentID.Value);
                else lblMsg.Text = "updated unsucessfull. Please try again ! <br/>";
                //DatabaseLayer
            }
            catch { }
        }
    }
}