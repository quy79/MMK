using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class mylists : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Utils.CheckSecurity(Session, Response);
            if (!IsPostBack) LoadData();
        }

        private void LoadData()
        {
            DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
            objList.USERID = Int32.Parse(Session["userID"].ToString());
            DataTable dtList = objList.SelectByUserID();
            grvList.DataSource = dtList;
            grvList.DataBind();
        }

        private void LoadDataGrid(int page, int pagesize)
        {
            
            grvList.PageIndex = page;
            grvList.PageSize = pagesize;
            LoadData();
        }

        

        protected void grvList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton l = (LinkButton)e.Row.FindControl("LinkDelete");
                l.Attributes.Add("onclick", "javascript:return " +
                "confirm('Are you sure you want to delete this list? ')");
            }
        }

        protected void grvList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DelItem")
            {
                
                int listID = Convert.ToInt32(e.CommandArgument);
                //delete all records in contact_list
                DatabaseLayer.Contact_list contlist = new DatabaseLayer.Contact_list();
                contlist.LISTID = listID;
                contlist.Delete();
                //delete in List;
                DatabaseLayer.Lists list = new DatabaseLayer.Lists();
                list.ID = listID;
                list.Delete();
                LoadData();
            }

        }

        protected void grvList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int iPageIndex = e.NewPageIndex;
            grvList.PageIndex = iPageIndex;
            LoadData();
        }

        protected void ddlRowPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pagesize = Int32.Parse(ddlRowPage.SelectedValue);
            grvList.PageSize = pagesize;
            grvList.PageIndex = 0;
            LoadData();

        }
    }
}