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

        private int iCurrentPage;
        private int iTotalRecord;
        private int iTotalPage;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Utils.CheckSecurity(Session, Response);
                if (!IsPostBack) LoadData();
                BindPaging();
            }
            catch { }
        }

        private void LoadData()
        {
            DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
            objList.USERID = Int32.Parse(Session["userID"].ToString());
            DataTable dtList = objList.SelectByUserID();
            grvList.DataSource = dtList;
            grvList.DataBind();
            TotalSize.Value = dtList.Rows.Count.ToString();
            iTotalRecord = dtList.Rows.Count;
            iTotalPage = (iTotalRecord / Int32.Parse(ddlRowPage.SelectedValue)) + (((iTotalRecord % Int32.Parse(ddlRowPage.SelectedValue)) > 0) ? 1 : 0);

            TotalPages.Value = iTotalPage.ToString();
            TotalSize.Value = iTotalRecord.ToString();
            lblCurrentPage.Text = CurrentPage.Value;
            lblTotalPages.Text = iTotalPage.ToString();
            BindPaging();
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
                System.Web.UI.HtmlControls.HtmlGenericControl noticeContentDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                noticeContentDiv.ID = "infoDivCode";
                noticeContentDiv.Style.Add("position", "relative");
                noticeContentDiv.Style.Add("margin", "20px auto");
                noticeContentDiv.Style.Add("padding", "20px 0px 0px 80px");
                noticeContentDiv.Style.Add("width", "520px");
                noticeContentDiv.Style.Add("height", "40px");
                
                noticeContentDiv.Style.Add("background-color", "#fbf6d7");
                noticeContentDiv.Style.Add("border", "1px solid #0b5d91");
                noticeContentDiv.Style.Add("-moz-border-radius", "6px 6px 6px 6px");
                noticeContentDiv.Style.Add("border-radius", "6px 6px 6px 6px");
                noticeContentDiv.Style.Add("-webkit-border-radius", "6px 6px 6px 6px");
               
                noticeContentDiv.Style.Add("background-repeat", "no-repeat");
                noticeContentDiv.Style.Add("background-position", "10px center");
                noticeContentDiv.Style.Add("font-size", "13px");
                noticeContentDiv.Style.Add("font-weight", "500");
                noticeContentDiv.Style.Add("text-align", "left");
                noticeContentDiv.Style.Add("clear", "both");

                int listID = Convert.ToInt32(e.CommandArgument);
                DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
                objList.ID = listID;
                if (!objList.CheckListIsUsed())
                {
                    //delete all records in contact_list
                    DatabaseLayer.Contact_list contlist = new DatabaseLayer.Contact_list();
                    contlist.LISTID = listID;
                    contlist.Delete();
                    //delete in List;
                    DatabaseLayer.Lists list = new DatabaseLayer.Lists();
                    list.ID = listID;
                    list.Delete();

                    noticeContentDiv.Style.Add("color", "#000000");
                    noticeContentDiv.Style.Add("background-image", "url(../../img/check.png)");
                    noticeContentDiv.InnerHtml = "List was successful deleted.";

                }
                else
                {
                    noticeContentDiv.Style.Add("color", "red");
                    noticeContentDiv.Style.Add("background-image", "url(../../img/error.png)");
                    noticeContentDiv.InnerHtml = "Error: There are messages are sending or segments are using this list, can not delete now !";
                }
                infoDiv.Controls.Add(noticeContentDiv);
                LoadData();
            }

        }

        protected void grvList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //int iPageIndex = e.NewPageIndex;
            //grvList.PageIndex = iPageIndex;
            //LoadData();
        }

        protected void ddlRowPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pagesize = Int32.Parse(ddlRowPage.SelectedValue);
            grvList.PageSize = pagesize;
            grvList.PageIndex = 0;
            CurrentPage.Value = "1";
            LoadData();

        }

        protected void last_Click(object sender, EventArgs e)
        {
            Page_List(sender, e);
        }

        protected void next_Click(object sender, EventArgs e)
        {
            Page_List(sender, e);
        }

        protected void prev_Click(object sender, EventArgs e)
        {
            Page_List(sender, e);
        }

        protected void first_Click(object sender, EventArgs e)
        {
            Page_List(sender, e);
        }
        
        private void BuildPagers()
        {
            if (((int.Parse(CurrentPage.Value)) - 1) > 0)
            {
                prev.Visible = true;
                first.Visible = true;
            }
            else
            {
                prev.Visible = false;
                first.Visible = false;
            }

            if (int.Parse(CurrentPage.Value) * int.Parse(ddlRowPage.SelectedValue) > int.Parse(TotalSize.Value))
            {
                next.Visible = false;
                last.Visible = false;
            }
            else
            {
                next.Visible = true;
                last.Visible = true;
            }
        }

        public void Page_List(object sender, EventArgs e)
        {
            if (((LinkButton)sender).ID == "prev")
            {
                if (!String.IsNullOrEmpty(CurrentPage.Value))
                {
                    if (((int.Parse(CurrentPage.Value)) - 1) > 0)
                    {
                        CurrentPage.Value = Convert.ToString(int.Parse(CurrentPage.Value) - 1);
                    }
                }
            }

            else if (((LinkButton)sender).ID == "next")
            {
                if (!String.IsNullOrEmpty(CurrentPage.Value))
                {
                    if (int.Parse(CurrentPage.Value) * int.Parse(ddlRowPage.SelectedValue) < int.Parse(TotalSize.Value))
                    {
                        CurrentPage.Value = Convert.ToString(int.Parse(CurrentPage.Value) + 1);
                    }
                }
            }

            else if (((LinkButton)sender).ID == "last")
            {
                if (!String.IsNullOrEmpty(CurrentPage.Value))
                {
                    if (int.Parse(CurrentPage.Value) * int.Parse(ddlRowPage.SelectedValue) < int.Parse(TotalSize.Value))
                    {
                        CurrentPage.Value = Convert.ToString((int.Parse(TotalSize.Value) / int.Parse(ddlRowPage.SelectedValue)) + 1);
                    }
                }
            }

            else if (((LinkButton)sender).ID == "first")
            {
                if (String.IsNullOrEmpty(CurrentPage.Value))
                    CurrentPage.Value = "1";

                if (((int.Parse(CurrentPage.Value)) - 1) > 0)
                    CurrentPage.Value = "1";
            }

            iCurrentPage = Int32.Parse(CurrentPage.Value);
            grvList.PageIndex = iCurrentPage - 1;
            grvList.PageSize = int.Parse(ddlRowPage.SelectedValue);
            LoadData();
        }

        private void BindPaging()
        {
            lblPaging.Controls.Clear();
            int startI = (Int32.Parse(CurrentPage.Value) / Int32.Parse(ddlRowPage.SelectedValue)) * Int32.Parse(ddlRowPage.SelectedValue) + 1;
            //int startI = Int32.Parse(CurrentPage.Value) % Int32.Parse
            int endI = startI + 9;
            if (endI > Int32.Parse(TotalPages.Value)) endI = Int32.Parse(TotalPages.Value);

            for (int i = startI; i <= endI; ++i)
            {
                if (i == Int32.Parse(CurrentPage.Value))
                {
                    Label lblPage = new Label();
                    lblPage.ID = "lblTmp_" + i.ToString();
                    lblPage.Text = i.ToString();
                    lblPage.CssClass = "paging";
                    lblPaging.Controls.Add(lblPage);
                    
                }
                else
                {
                    LinkButton lnk = new LinkButton();
                    lnk.ID = "lnk" + i.ToString();
                    lnk.CausesValidation = false;
                    lnk.Text = i.ToString();
                    lnk.CommandArgument = i.ToString();
                    lnk.Click += new EventHandler(Page_List_lnk);
                    lblPaging.Controls.Add(lnk);
                }

                Label lbl = new Label();
                lbl.ID = "lblTmp" + i.ToString();
                lbl.Text = " ";
                lblPaging.Controls.Add(lbl);
            }
            
        }

        public void Page_List_lnk(object sender, EventArgs e)
        {
            string[] charval = { "lnk" };
            string[] strlId = (((LinkButton)sender).ID).Split(charval, StringSplitOptions.RemoveEmptyEntries);
            CurrentPage.Value = strlId[0];
            grvList.PageIndex = Int32.Parse(strlId[0]) - 1;
            LoadData();
            //string xfdsf = (((LinkButton)sender).ID).Remove(0, 3);
            //if (!String.IsNullOrEmpty(xfdsf))
               // rptBindGrid_k(xfdsf);
        }


    }
}