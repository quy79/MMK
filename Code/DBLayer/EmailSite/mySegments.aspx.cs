using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class mySegments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Utils.CheckSecurity(Session, Response);
                if (!IsPostBack) LoadData();
            }
            catch { }
        }

        private void LoadData()
        {
            DatabaseLayer.Segment objSegment = new DatabaseLayer.Segment();
            objSegment.USERID = Int32.Parse(Session["userID"].ToString());
            DataTable dtSegment = objSegment.SelectByUserID();
            grvList.DataSource = dtSegment;
            grvList.DataBind();
            if (dtSegment != null && dtSegment.Rows.Count > 0) pnlList.Visible = true;
            else pnlList.Visible = false;
        }


        protected void grvList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton l = (LinkButton)e.Row.FindControl("LinkDelete");
                l.Attributes.Add("onclick", "javascript:return " +
                "confirm('Are you sure you want to delete this segment? ')");
            }
        }

        protected void grvList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DelItem")
            {

                int listID = Convert.ToInt32(e.CommandArgument);
                //delete all records in contact_list
                DatabaseLayer.Segment objSegment = new DatabaseLayer.Segment();
                objSegment.ID = listID;
                objSegment.Delete();
                LoadData();
                
            }

        }
    }
}