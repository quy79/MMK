using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class chooseEmailList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack) LoadData();
        }

        private void LoadData()
        {
            DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
            objList.USERID = Int32.Parse(Session["userID"].ToString());
            DataTable dtList = objList.SelectByUserID();
            grvList.DataSource = dtList;
            grvList.DataBind();
        }

        protected void grvList_PageIndexChanged(object sender, EventArgs e)
        {

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

        protected void lnkBack_Click(object sender, EventArgs e)
        {
            if (Session["currentTextEmail"] != null)
            {
                TextMessage objMsg = (TextMessage)Session["currentTextEmail"];
                if(objMsg.TypeMsg ==1 )    Response.Redirect("createTextEmail.aspx");
                if (objMsg.TypeMsg == 2) Response.Redirect("createHTMLEmail.aspx");
            }
        }

        protected void btnPreview_Click(object sender, EventArgs e)
        {
            string strListSelected = Request["target_list"];

            if (strListSelected == null || strListSelected.Length == 0)
            {
            }
            else
            {
                if (Session["currentTextEmail"] != null)
                {
                    TextMessage objMsg = (TextMessage)Session["currentTextEmail"];
                    objMsg.ListID = Int32.Parse(strListSelected);
                    Session["currentTextEmail"] = objMsg;

                    Response.Redirect("previewEmail.aspx");
                }
            }

        }
    }
}