using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class createSegment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) LoadContactLists();
            lblMsg.Text = "";
        }

        private void LoadContactLists()
        {
            //DatabaseLayer 
            DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
            objList.USERID = Int32.Parse(Session["userID"].ToString());
            DataTable dtList = objList.SelectByUserID();
            ddlList.DataSource = dtList;
            ddlList.DataBind();

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
                objSegment.USERID = Int32.Parse(Session["userID"].ToString());
                objSegment.NAME = txtName.Text.Trim();
                objSegment.DESCRIPTION = txtDesc.Text.Trim();
                objSegment.LISTID = Int32.Parse(ddlList.SelectedValue);

                int iSegmentID = objSegment.Insert();

                if (iSegmentID > 0) Response.Redirect("addSegementCriterias.aspx?id=" + iSegmentID.ToString());
                else lblMsg.Text = "The new segment is added unsucessfull. Please try again ! <br/>";
                //DatabaseLayer
            }
            catch { }
        }
    }
}