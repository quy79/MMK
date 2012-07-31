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
            try
            {
                Utils.CheckSecurity(Session, Response);
                //init value
                //lblUnSubscribe.Text = "Unsubscribe";
                //btnUnsubContacts.Text = "Unsubscribe Contacts from List";
                if (!IsPostBack)
                {
                    if (Request["listID"] != null
                        || Request["segmentID"] != null)
                    {
                        pnlSearch.Visible = false;
                       
                        if (Request["listID"] != null)
                        {
                            //
                            try
                            {
                                pnlInfo.Visible = true;
                                DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
                                objList.ID = Int32.Parse(Request["listID"]);
                                DataTable dtList = objList.SelectByID();
                                lblListInfo.Text = "Contact List: " + dtList.Rows[0]["LISTNAME"];
                            }
                            catch { }
                            hdModeSearch.Value = "5";
                        }

                        if (Request["segmentID"] != null)
                        {
                            if (Request["hideMenu"] != null)
                            {
                                logo.Visible = false;
                                navigation.Visible = false;
                            }
                            hdModeSearch.Value = "6";
                        }
                        LoadData();
                    }
                    else
                    {
                        pnlSearch.Visible = true;
                        pnlInfo.Visible = false;
                    }

                    LoadContactLists();
                    first.Visible = false;
                    last.Visible = false;
                    next.Visible = false;
                    prev.Visible = false;
                }
                lblMsg.Text = "";
                BindPaging();

                try
                {
                    DatabaseLayer.Contacts objContact = new DatabaseLayer.Contacts();
                    objContact.USERID = Int32.Parse(Session["userID"].ToString());
                    DataTable dtContact = objContact.SelectSummartContacts();
                    lblTotalContacts.Text = dtContact.Rows[0]["TOTALCONTACTS"].ToString();
                    lblTotalSub.Text = dtContact.Rows[0]["TOTALSUB"].ToString();
                }
                catch { lblTotalContacts.Text = "0"; lblTotalSub.Text = "0"; }


            }
            catch { }
        }

        private void LoadGridContacts(DataTable dtTable)
        {
            selectContactContainer.DataSource = dtTable;
            selectContactContainer.DataBind();
        }
        private void LoadContactLists()
        {
            //DatabaseLayer 
            DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
            objList.USERID = Int32.Parse(Session["userID"].ToString());
            DataTable dtList = objList.SelectByUserID();
            

            ddlCopyContacts.DataSource = dtList;
            ddlCopyContacts.DataBind();

            ddlUnsubContacts.DataSource = dtList;
            ddlUnsubContacts.DataBind();

            dtList = objList.SelectListsAndSegmentsByUserID();
            lstContactLists.DataSource = dtList;
            lstContactLists.DataBind();
            lstContactLists.Items.Insert(0, new ListItem("All lists and segments", "0"));
           
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

        private DataTable GetContactsFromSegment(int segID, bool subcribes)
        {
            try
            {
                string sub = (subcribes) ? "1" : "0";
                string strQuery = "select distinct ct.* from CONTACTS ct INNER JOIN CONTACT_LIST cl ON ct.ID = cl.CONTACTID WHERE ct.USERID = " + Session["userID"].ToString() + " AND ( cl.SUBSCRIBES = " + sub + " ) ";
                
                DatabaseLayer.SegmentCriterias objSegCri = new DatabaseLayer.SegmentCriterias();
                objSegCri.SEGMENTID = segID;
                DataTable dtSegCri = objSegCri.SelectBySegmentID();
                foreach (DataRow row in dtSegCri.Rows)
                {
                    strQuery += "AND " + row["CONDITION"].ToString();

                }
                
                DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                return objContacts.ExecuteSql(strQuery);
            }
            catch { }
            return null;
        }

        private void LoadData()
        {
            try
            {
            
                if (hdModeSearch.Value == "1")
                {
                    string strSelectedIDs = lstContactLists.SelectedValue;
                    if(strSelectedIDs.Equals("0")) { // select all lists and segments
                        DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                        objContacts.USERID = Int32.Parse(Session["userID"].ToString());
                        //dtContactLists = objContacts.QuickSearch("", !chkUnSub1.Checked);
                        if (chkUnSub1.Checked) dtContactLists = objContacts.BrowseAll(false);
                        else dtContactLists = objContacts.BrowseAll( true);
                    } else {
                        if (strSelectedIDs[0]=='L') {
                            DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                            dtContactLists = objContacts.SelectContactListsbyListIDs(Int32.Parse(strSelectedIDs.Substring(1)), !chkUnSub1.Checked);
                        } else {//segment
                            dtContactLists =  GetContactsFromSegment(Int32.Parse(strSelectedIDs.Substring(1)), !chkUnSub1.Checked);
                        }
                       
                    }

                    if (chkUnSub1.Checked)
                    {
                        lblUnSubscribe.Text = "Subscribe";
                        btnUnsubContacts.Text = "Subscribe Contacts from List";
                    }
                    else
                    {
                        lblUnSubscribe.Text = "Unsubscribe";
                        btnUnsubContacts.Text = "Unsubscribe Contacts from List";
                    }
                
                }
                else if (hdModeSearch.Value == "2")
                {
                    DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                    objContacts.USERID = Int32.Parse(Session["userID"].ToString());
                    dtContactLists = objContacts.SelectAll();
                
                }
                else if (hdModeSearch.Value == "3")
                {
                    DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                    objContacts.USERID = Int32.Parse(Session["userID"].ToString());
                    dtContactLists = objContacts.QuickSearch(txtQSearch.Text.Trim(), !chkUnsub2.Checked);
                    if (chkUnsub2.Checked)
                    {
                        lblUnSubscribe.Text = "Subscribe";
                        btnUnsubContacts.Text = "Subscribe Contacts from List";
                    }
                    else
                    {
                        lblUnSubscribe.Text = "Unsubscribe";
                        btnUnsubContacts.Text = "Unsubscribe Contacts from List";
                    }
                
                }
                else if (hdModeSearch.Value == "4")
                {
                    DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                    objContacts.USERID = Int32.Parse(Session["userID"].ToString());
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
                        dt1 = dt1.AddMinutes(-1);
                    }
                    catch { }

                    DateTime dt2 = DateTime.MaxValue;
                    try {
                        dt2 = DateTime.Parse(date2.Text.Trim());
                        dt2 = dt2.AddDays(1);
                    }
                    catch { }

                    dtContactLists = objContacts.Select(dt1, dt2);

                }
                else if (hdModeSearch.Value == "5")
                {
                    try
                    {
                        DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                        dtContactLists = objContacts.SelectContactListsbyListIDs(Int32.Parse(Request["listID"]), true);
                        lblSubscribeContact.Text = objContacts.SelectContactListsbyListIDs(Int32.Parse(Request["listID"]), true).Rows.Count.ToString();
                        lnkShowUnsubscribe.Text = "show " + objContacts.SelectContactListsbyListIDs(Int32.Parse(Request["listID"]), false).Rows.Count.ToString() + " unsubscribed contacts";
                    }
                    catch { }
                }
                else if (hdModeSearch.Value == "6")
                {
                    dtContactLists = GetContactsFromSegment(Int32.Parse(Request["segmentID"]), !chkUnSub1.Checked);

                }
                else if (hdModeSearch.Value == "7")
                {
                    try
                    {
                        DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                        dtContactLists = objContacts.SelectContactListsbyListIDs(Int32.Parse(Request["listID"]), false);
                        lblSubscribeContact.Text = objContacts.SelectContactListsbyListIDs(Int32.Parse(Request["listID"]), true).Rows.Count.ToString();
                        lnkShowUnsubscribe.Text = "show " + objContacts.SelectContactListsbyListIDs(Int32.Parse(Request["listID"]), false).Rows.Count.ToString() + " unsubscribed contacts";
                    }
                    catch { }
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

            try
            {
                DatabaseLayer.Contacts objContact = new DatabaseLayer.Contacts();
                objContact.USERID = Int32.Parse(Session["userID"].ToString());
                DataTable dtContact = objContact.SelectSummartContacts();
                lblTotalContacts.Text = dtContact.Rows[0]["TOTALCONTACTS"].ToString();
                lblTotalSub.Text = dtContact.Rows[0]["TOTALSUB"].ToString();
            }
            catch { lblTotalContacts.Text = "0"; lblTotalSub.Text = "0"; }
        }

        protected void btnBrowse_Click(object sender, EventArgs e)
        {
            hdModeSearch.Value = "1";
            LoadData();
            

        }

        protected void ddlRowPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pagesize = Int32.Parse(ddlRowPage.SelectedValue);
            selectContactContainer.PageSize = pagesize;
            selectContactContainer.PageIndex = 0;
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
            selectContactContainer.PageIndex = iCurrentPage - 1;
            selectContactContainer.PageSize = int.Parse(ddlRowPage.SelectedValue);
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
            selectContactContainer.PageIndex = Int32.Parse(strlId[0]) - 1;
            LoadData();
            //string xfdsf = (((LinkButton)sender).ID).Remove(0, 3);
            //if (!String.IsNullOrEmpty(xfdsf))
            // rptBindGrid_k(xfdsf);
        }

        private ArrayList GetSelectedContactID()
        {
            ArrayList objIDs = new ArrayList();
            foreach (GridViewRow row in selectContactContainer.Rows)
            {
                CheckBox chk = (CheckBox)row.FindControl("selectContact");
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
                lblMsg.Text = Utils.ShowMessage("Please select aleast a contact !", true);
                return;
            }

            if (ddlCopyContacts.Items.Count == 0 && txtCopyList.Text.Trim().Length == 0)
            {
                lblMsg.Text = Utils.ShowMessage("Please select aleast a list !", true);
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
                int isDuplicate = 0;

                isDuplicate = objContactList.CheckDuplicateContact();
                if (isDuplicate == 0)
                {
                    if (objContactList.Insert()) isUpdated = true;
                }
            }

            if (isUpdated)
            {
                UpdateTotalSubscribers(ddlCopyContacts.SelectedValue);                 
                lblMsg.Text = Utils.ShowMessage("Selected contacts is copied sucessfully !", false);
            }

        }

        protected void btnDeleteContacts_Click(object sender, EventArgs e)
        {
            ArrayList arrListID = GetSelectedContactID();

            if (arrListID.Count == 0)
            {
                lblMsg.Text = Utils.ShowMessage("Please select aleast a contact !", true);
                return;
            }

            bool isUpdated = false;

            for (int i = 0; i < arrListID.Count; i++)
            {
                int iContactID = Int32.Parse(arrListID[i].ToString());
                DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                objContacts.ID = iContactID;
                objContacts.USERID = Int32.Parse(Session["userID"].ToString());


                if (objContacts.Delete()) isUpdated = true;
                LoadData();
            }

            if (isUpdated)
            {
                //UpdateTotalSubscribers(ddlUnsubContacts.SelectedValue);
                lblMsg.Text = Utils.ShowMessage("Selected contacts is deleted sucessfully !", false);
            }
        }

        protected void btnExportContacts_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder strBuild = new System.Text.StringBuilder();
            ArrayList arrListID = GetSelectedContactID();

            if (arrListID.Count == 0)
            {
                lblMsg.Text = Utils.ShowMessage("Please select aleast a contact !", true);
                return;
            }


            //strBuild.AppendLine("Email,FirstName,LastName");
            strBuild.AppendLine("Email");
            for (int i = 0; i < arrListID.Count; i++)
            {
                int iContactID = Int32.Parse(arrListID[i].ToString());
                DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                objContacts.ID = iContactID;
                DataTable objTab= objContacts.SelectContactsFromContactID();
                try
                {
                    string strLine = objTab.Rows[0]["EMAIL"].ToString();// +"," + objTab.Rows[0]["FIRSTNAME"].ToString() + "," + objTab.Rows[0]["LASTNAME"].ToString();
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
                lblMsg.Text = Utils.ShowMessage("Please select aleast a contact !", true);
                return;
            }

            if (ddlUnsubContacts.Items.Count == 0)
            {
                lblMsg.Text = Utils.ShowMessage("Please select aleast a list !", true);
                return;
            }

            int iListID = Int32.Parse(ddlUnsubContacts.SelectedValue);

            bool isUpdated = false;
            string strMode = "Unsubscribed";
            if (lblUnSubscribe.Text.Equals("Unsubscribe")) strMode = "Unsubscribed";
            else strMode = "Subscribed";

            for (int i = 0; i < arrListID.Count; i++)
            {
                int iContactID = Int32.Parse(arrListID[i].ToString());
                DatabaseLayer.Contact_list objContactList = new DatabaseLayer.Contact_list();
                objContactList.CONTACTID = iContactID;
                objContactList.LISTID = iListID;
                
                if (strMode == "Unsubscribed")
                    objContactList.SUBSCRIBES = false;
                else objContactList.SUBSCRIBES = true;
               // if (objContactList.Update()) isUpdated = true;
                if (objContactList.SubscribeContact(objContactList.CONTACTID, objContactList.SUBSCRIBES, Int32.Parse(Session["userID"].ToString()))) isUpdated = true;
            }

            if (isUpdated)
            {
                //UpdateTotalSubscribers(ddlUnsubContacts.SelectedValue);
                //we updated it in store procedure
                lblMsg.Text = Utils.ShowMessage("Selected contacts is "+strMode+" sucessfully !", false);
                LoadData();
            }
            else
            {
                lblMsg.Text = Utils.ShowMessage("Selected contacts is " + strMode + " unsucessfully. Please make sure that selected contacts are existed in selected list !", true);
            }
        }

        private void UpdateTotalSubscribers(string strID)
        {
            DatabaseLayer.Contact_list objContactList = new DatabaseLayer.Contact_list();
            objContactList.LISTID = Int32.Parse(strID);
            DataTable dt = objContactList.SelectByListID();
            int totalSubscribes = dt.Rows.Count;

            DatabaseLayer.Lists objList1 = new DatabaseLayer.Lists();
            objList1.USERID = Int32.Parse(Session["userID"].ToString());
            objList1.ID = Int32.Parse(strID);
            objList1.TOTALSUBSCRIBES = totalSubscribes;
            objList1.UpdateTotalSubscribers();
        }

        protected void selectContactContainer_DataBound(object sender, EventArgs e)
        {

        }

        protected void selectContactContainer_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                try
                {
                    Label lb = (Label)e.Row.FindControl("lblListName");

                    lb.Text = "";
                    DataRowView dataRow = (DataRowView)e.Row.DataItem;
                    int contactID = Int32.Parse(dataRow["ID"].ToString());
                    DatabaseLayer.Contacts objCt = new DatabaseLayer.Contacts();

                    DataTable dt = objCt.GetListNamesForCountactID(contactID);
                    foreach (DataRow row in dt.Rows)
                    {
                        if (lb.Text.Length == 0) lb.Text = row["LISTNAME"].ToString();
                        else lb.Text += "," + row["LISTNAME"].ToString();
                    }

                }
                catch { }
            }
        }

        protected void lnkShowUnsubscribe_Click(object sender, EventArgs e)
        {
            hdModeSearch.Value = "7";
            lblUnSubscribe.Text = "Subscribe";
            btnUnsubContacts.Text = "Subscribe Contacts from List";
            LoadData();
        }


    }
}