using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class addSegementCriterias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Utils.CheckSecurity(Session, Response);
                if (!IsPostBack)
                {
                    if (Request["id"] == null) lblMsg.Text = "Please choose a segment to add criterias !";
                    else hdSegmentID.Value = Int32.Parse(Request["id"].ToString()).ToString();
                    LoadData();
                }
                lblMsg.Text = "";
            }
            catch { }
        }

        private void LoadData()
        {
            
            //load segment by ID
            DatabaseLayer.Segment objSeg = new DatabaseLayer.Segment();
            objSeg.ID = Int32.Parse(hdSegmentID.Value);
            DataTable dtTable = objSeg.SelectBySegmentID();
            if (dtTable != null)
            {
                lblName.Text = dtTable.Rows[0]["NAME"].ToString();
                lblDesc.Text = dtTable.Rows[0]["DESCRIPTION"].ToString();
                DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
                objList.ID = Int32.Parse(dtTable.Rows[0]["LISTID"].ToString());
                DataTable dtList = objList.SelectByID();
                if (dtList != null) lblListName.Text = dtList.Rows[0]["LISTNAME"].ToString();

                //load Grid
                DatabaseLayer.SegmentCriterias objSegCri = new DatabaseLayer.SegmentCriterias();
                objSegCri.SEGMENTID = Int32.Parse(hdSegmentID.Value);
                DataTable dtSegCri = objSegCri.SelectBySegmentID();
                grvCriterion.DataSource = dtSegCri;
                grvCriterion.DataBind();
                if (dtSegCri != null && dtSegCri.Rows.Count > 0) pnlCriterias.Visible = true;
                else pnlCriterias.Visible = false;
                //ddlList.Items.FindByValue(dtTable.Rows[0]["LISTID"].ToString()).Selected = true;
            }

        }

        protected void grvCriterion_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton l = (LinkButton)e.Row.FindControl("LinkDelete");
                l.Attributes.Add("onclick", "javascript:return " +
                "confirm('Are you sure you want to delete this criteria ? ')");
            }
        }

        protected void grvCriterion_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DelItem")
            {

                int listID = Convert.ToInt32(e.CommandArgument);
                DatabaseLayer.SegmentCriterias objSegCri = new DatabaseLayer.SegmentCriterias();
                objSegCri.ID = listID;
                objSegCri.Delete();
                LoadData();
            }

        }


        protected void btnAddCriteria1_Click(object sender, EventArgs e)
        {            
            string strCriterion = "Date added to account";
            string strConditionName = date_range.SelectedItem.Text;
            string strCondition = "";
            string strValue = "";
            if (date_range.SelectedIndex != 3)
            {
                try
                {
                    DateTime dtDate = DateTime.Parse(date.Text);
                    strValue = date.Text;
                }
                catch {
                    lblMsg.Text = "Please select correct date";
                    return;
                }
            }
            else
            {
                try
                {
                    DateTime dtDate1 = DateTime.Parse(date1.Text);
                    DateTime dtDate2 = DateTime.Parse(date2.Text);
                    strValue = date1.Text + " and " + date2.Text;
                  //  strCondition = " ( MODIFIEDDATE BETWEEN '" + date1.Text + "' AND '" + date2.Text + "' ) ";
                }
                catch
                {
                    lblMsg.Text = "Please select correct date";
                    return;
                }
            }

            string strDate = date.Text + " 00:00:01";
            string strDate1 = date1.Text + " 00:00:01";
            string strDate2 = date2.Text + " 00:00:01";
            switch (date_range.SelectedIndex)
            {
                case 0:
                    strCondition = " ( DATEDIFF(day,ct.MODIFIEDDATE, Convert(datetime,'" + strDate + "',110 )) = 0 ) ";
                    break;
                case 1:
                    strCondition = " ( DATEDIFF(day,ct.MODIFIEDDATE, Convert(datetime,'" + strDate + "',110 )) < 0 ) ";
                    break;
                case 2:
                    strCondition = " ( DATEDIFF(day,ct.MODIFIEDDATE, Convert(datetime,'" + strDate + "',110 )) > 0 ) ";
                    break;
                case 3:
                    strCondition = " ( ct.MODIFIEDDATE  BETWEEN Convert(datetime,'" + strDate1 + "',110 )  AND   Convert(datetime,'" + strDate2 + "',110 )  ) ";
                    break;
                default:
                    break;
            }

            

            bool inSet = InsertSegmentCriteria(Int32.Parse(hdSegmentID.Value), strCriterion, strConditionName, strCondition, strValue);
            if (!inSet) lblMsg.Text = "new criteria is added unsucessful. Please try again";


        }

        protected void btnAddCriteria2_Click(object sender, EventArgs e)
        {
            string strCriterion = subscriber_fields.SelectedItem.Text;
            string strConditionName = conditional.SelectedItem.Text;
            string strCondition = conditional.SelectedItem.Text;
            string strValue = "\""+ txtFV.Text.Trim()+"\"";

            switch (conditional.SelectedIndex) 
            {
                case 0:
                    strCondition = " ( ct." + subscriber_fields.SelectedValue + " = '" + txtFV.Text.Trim() + "' ) ";
                    break;
                case 1:
                    strCondition = " ( ct." + subscriber_fields.SelectedValue + " !='" + txtFV.Text.Trim() + "') ";
                    break;
                case 2:
                    strCondition = " ( ct." + subscriber_fields.SelectedValue + " like '%" + txtFV.Text.Trim() + "%') ";
                    break;
                case 3:
                    strCondition = " ( ct." + subscriber_fields.SelectedValue + " not like '%" + txtFV.Text.Trim() + "%') ";
                    break;
                default:
                    break;
            }

            

            bool inSet = InsertSegmentCriteria(Int32.Parse(hdSegmentID.Value), strCriterion, strConditionName, strCondition, strValue);
            if (!inSet) lblMsg.Text = "new criteria is added unsucessful. Please try again";
        }

        private bool InsertSegmentCriteria(int segmentID, string  criterion, string conditionName, string condition, string value)
        {
            DatabaseLayer.SegmentCriterias objSegmentCri = new DatabaseLayer.SegmentCriterias();
            objSegmentCri.SEGMENTID = segmentID;
            objSegmentCri.CRITERION = criterion;
            objSegmentCri.CONDITIONNAME = conditionName;
            objSegmentCri.CONDITION = condition;
            objSegmentCri.VALUE = value;

            bool isInsert = objSegmentCri.Insert();
            LoadData();
            return isInsert;
        }

        protected void btnSaveandNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("createSegment.aspx");
        }
    }
}