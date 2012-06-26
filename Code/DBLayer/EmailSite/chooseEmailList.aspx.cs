﻿using System;
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

        private int iCurrentPage;
        private int iTotalRecord;
        private int iTotalPage;

        protected void Page_Load(object sender, EventArgs e)
        {
            Utils.CheckSecurity(Session, Response);
            if (!IsPostBack) LoadData();
            BindPaging();
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
            CurrentPage.Value = "1";
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