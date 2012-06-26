using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class searchContacts : System.Web.UI.Page
    {
        private int iCurrentPage;
        private int iTotalRecord;
        private int iTotalPage;
        DataTable dtContactLists;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadContactLists();
                first.Visible = false;
                last.Visible = false;
                next.Visible = false;
                prev.Visible = false;
            }
            lblMsg.Text = "";
            BindPaging();
        }

        private void LoadGridContacts(DataTable dtTable)
        {
            grvContacts.DataSource = dtTable;
            grvContacts.DataBind();
        }
        private void LoadContactLists()
        {
            //DatabaseLayer 
            DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
            objList.USERID = Int32.Parse(Session["userID"].ToString());
            DataTable dtList = objList.SelectByUserID();
            lstContactLists.DataSource = dtList;
            lstContactLists.DataBind();

            ddlCopyContacts.DataSource = dtList;
            ddlCopyContacts.DataBind();

            ddlUnsubContacts.DataSource = dtList;
            ddlUnsubContacts.DataBind();
        }

        protected void btnQSearch_Click(object sender, EventArgs e)
        {
            hdModeSearch.Value = "3";
            LoadData();
            
            
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            hdModeSearch.Value = "4";
            LoadData();

           

        }

        protected void lnkBrowseAll_Click(object sender, EventArgs e)
        {
            hdModeSearch.Value = "2";
            LoadData();
            
        }

        private void LoadData()
        {
            try
            {
            
                if (hdModeSearch.Value == "1")
                {
                    string strSelectedIDs = "";
                    foreach (ListItem item in lstContactLists.Items)
                    {
                        if (item.Selected)
                            if (strSelectedIDs == "") strSelectedIDs = item.Value;
                            else strSelectedIDs += "," + item.Value;
                    }

                    DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                    dtContactLists = objContacts.SelectContactListsbyListIDs(strSelectedIDs);
                
                }
                else if (hdModeSearch.Value == "2")
                {
                    DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                    dtContactLists = objContacts.SelectAll();
                
                }
                else if (hdModeSearch.Value == "3")
                {
                    DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                    dtContactLists = objContacts.QuickSearch(txtQSearch.Text.Trim());
                
                }
                else if (hdModeSearch.Value == "4")
                {
                    DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                    objContacts.PREFIX = txtPrefix.Text.Trim();
                    objContacts.SUFFIX = txtSuffix.Text.Trim();
                    objContacts.FIRSTNAME = txtFName.Text.Trim();
                    objContacts.LASTNAME = txtLName.Text.Trim();

                    objContacts.ADDRESS1 = txtAddress1.Text.Trim();
                    objContacts.ADDRESS2 = txtAddress2.Text.Trim();

                    objContacts.CITY = txtCity.Text.Trim();
                    objContacts.PROVINCE = txtProvince.Text.Trim();
                    objContacts.ZIP = txtZip.Text.Trim();

                    objContacts.BUSINESSNAME = txtBusiness.Text.Trim();
                    objContacts.PHONE = txtPhone.Text.Trim();
                    objContacts.FAX = txtFax.Text.Trim();

                    DateTime dt1 = DateTime.Parse("01/01/2000");
                    try { 
                        dt1 = DateTime.Parse(date1.Text.Trim()); 
                    }
                    catch { }

                    DateTime dt2 = DateTime.MaxValue;
                    try { dt2 = DateTime.Parse(date2.Text.Trim()); }
                    catch { }

                    dtContactLists = objContacts.Select(dt1, dt2);
                
                }
                LoadGridContacts(dtContactLists);

                TotalSize.Value = dtContactLists.Rows.Count.ToString();

            
                iTotalRecord = dtContactLists.Rows.Count;
                iTotalPage = (iTotalRecord / Int32.Parse(ddlRowPage.SelectedValue)) + (((iTotalRecord % Int32.Parse(ddlRowPage.SelectedValue)) > 0) ? 1 : 0);

                if (iTotalRecord > 0)
                {
                    pnlAction.Visible = true;
                    pnlSearchResutls.Visible = true;
                }
                else
                {
                    pnlAction.Visible = false;
                    pnlSearchResutls.Visible = false;
                }

                TotalPages.Value = iTotalPage.ToString();
                TotalSize.Value = iTotalRecord.ToString();
                lblCurrentPage.Text = CurrentPage.Value;
                lblTotalPages.Text = iTotalPage.ToString();

                first.Visible = (iTotalPage>1);
                last.Visible = (iTotalPage > 1);
                next.Visible = (iTotalPage > 1);
                prev.Visible = (iTotalPage > 1);

                BindPaging();
            }
            catch {
                pnlAction.Visible = false;
                pnlSearchResutls.Visible = false;
            }
        }

        protected void btnBrowse_Click(object sender, EventArgs e)
        {
            hdModeSearch.Value = "1";
            LoadData();
            

        }

        protected void ddlRowPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pagesize = Int32.Parse(ddlRowPage.SelectedValue);
            grvContacts.PageSize = pagesize;
            grvContacts.PageIndex = 0;
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
            grvContacts.PageIndex = iCurrentPage - 1;
            grvContacts.PageSize = int.Parse(ddlRowPage.SelectedValue);
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
            grvContacts.PageIndex = Int32.Parse(strlId[0]) - 1;
            LoadData();
            //string xfdsf = (((LinkButton)sender).ID).Remove(0, 3);
            //if (!String.IsNullOrEmpty(xfdsf))
            // rptBindGrid_k(xfdsf);
        }

        private ArrayList GetSelectedContactID()
        {
            ArrayList objIDs = new ArrayList();
            foreach (GridViewRow row in grvContacts.Rows)
            {
                CheckBox chk = (CheckBox)row.FindControl("Chk_select");
                HiddenField hd = (HiddenField)row.FindControl("hdContactID");
                //int id =Int32.Parse(row.Cells[0].ToString());
                if (chk.Checked) objIDs.Add(hd.Value);
            }

            return objIDs;
        }
        protected void btnCopyContacts_Click(object sender, EventArgs e)
        {
            ArrayList arrListID = GetSelectedContactID();

            if (arrListID.Count == 0)
            {
                lblMsg.Text = "Please select aleast a contact !";
                return;
            }

            if (ddlCopyContacts.Items.Count == 0 && txtCopyList.Text.Trim().Length == 0)
            {
                lblMsg.Text = "Please select aleast a list !";
                return;
            }
            

            int iListID = 0;
            if (txtCopyList.Text.Trim().Length > 0)
            {
                DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
                objList.LISTNAME = txtCopyList.Text.Trim();
                iListID = objList.getIDFromListName();
                if (iListID == 0)
                {
                    objList.USERID = Int32.Parse(Session["userID"].ToString());
                    objList.DESCRIPTION = "";
                    objList.NOTIFICATION = false;
                    objList.Insert();
                    iListID = objList.getIDFromListName();
                    //reload lists
                    LoadContactLists();
                }
            }

            if (iListID == 0) iListID = Int32.Parse(ddlCopyContacts.SelectedValue);

            bool isUpdated = false;
            
            for (int i = 0; i < arrListID.Count; i++)
            {
                int iContactID = Int32.Parse(arrListID[i].ToString());
                DatabaseLayer.Contact_list objContactList = new DatabaseLayer.Contact_list();
                objContactList.CONTACTID = iContactID;
                objContactList.LISTID = iListID;
                objContactList.SUBSCRIBES = true;

                if (objContactList.Insert()) isUpdated = true;
            }

            if(isUpdated) lblMsg.Text = "Selected contacts is copied sucessfully !";

        }

        protected void btnDeleteContacts_Click(object sender, EventArgs e)
        {
            ArrayList arrListID = GetSelectedContactID();

            if (arrListID.Count == 0)
            {
                lblMsg.Text = "Please select aleast a contact !";
                return;
            }

            bool isUpdated = false;

            for (int i = 0; i < arrListID.Count; i++)
            {
                int iContactID = Int32.Parse(arrListID[i].ToString());
                DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                objContacts.ID = iContactID;


                if (objContacts.Delete()) isUpdated = true;
                LoadData();
            }

            if(isUpdated)lblMsg.Text = "Selected contacts is deleted sucessfully !";
        }

        protected void btnExportContacts_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder strBuild = new System.Text.StringBuilder();
            ArrayList arrListID = GetSelectedContactID();

            if (arrListID.Count == 0)
            {
                lblMsg.Text = "Please select aleast a contact !";
                return;
            }


            strBuild.AppendLine("Email,FirstName,LastName");
            for (int i = 0; i < arrListID.Count; i++)
            {
                int iContactID = Int32.Parse(arrListID[i].ToString());
                DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                objContacts.ID = iContactID;
                DataTable objTab= objContacts.SelectContactsFromContactID();
                try
                {
                    string strLine = objTab.Rows[0]["EMAIL"].ToString() + "," + objTab.Rows[0]["FIRSTNAME"].ToString() + "," + objTab.Rows[0]["LASTNAME"].ToString();
                    strBuild.AppendLine(strLine);
                }
                catch { }
                

                
            }
            Response.ContentType = "text/csv";
            Response.AddHeader("Content-disposition", "attachment; filename=exportContacts.csv");
            Response.Write(strBuild.ToString());
            Response.End();

        }

        protected void btnUnsubContacts_Click(object sender, EventArgs e)
        {

            ArrayList arrListID = GetSelectedContactID();

            if (arrListID.Count == 0)
            {
                lblMsg.Text = "Please select aleast a contact !";
                return;
            }

            if (ddlUnsubContacts.Items.Count == 0)
            {
                lblMsg.Text = "Please select aleast a list !";
                return;
            }

            int iListID = Int32.Parse(ddlUnsubContacts.SelectedValue);

            bool isUpdated = false;

            for (int i = 0; i < arrListID.Count; i++)
            {
                int iContactID = Int32.Parse(arrListID[i].ToString());
                DatabaseLayer.Contact_list objContactList = new DatabaseLayer.Contact_list();
                objContactList.CONTACTID = iContactID;
                objContactList.LISTID = iListID;
                objContactList.SUBSCRIBES = false;

                if (objContactList.Update()) isUpdated = true;
            }

            if (isUpdated) lblMsg.Text = "Selected contacts is Unsubscribed sucessfully !";
        }


    }
}