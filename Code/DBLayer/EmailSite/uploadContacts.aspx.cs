using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseLayer;

namespace EmailSite
{
    public partial class uploadContacts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Request.QueryString["listid"].Equals(""))
                listsDiv.Visible = false;

            if (!Page.IsPostBack) LoadData();
        }

        private void LoadData()
        {
            DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
            objList.USERID = Int32.Parse(Session["userID"].ToString());
            DataTable dtList = objList.SelectByUserID();
            rptList.DataSource = dtList;
            rptList.DataBind();
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {

            string strListSelected;
            if (Request.QueryString["listid"].Equals(""))
                strListSelected = Request["listContact"];
            else
                strListSelected = Request.QueryString["listid"];

            if (strListSelected != null)
            {
                Stream theStream = file.PostedFile.InputStream;
                using (StreamReader sr = new StreamReader(theStream))
                {
                    string line;
                    int cnt = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        cnt++;
                        string email = "";
                        int iPos = line.IndexOf(',');
                        if (iPos > 0) email = line.Substring(0, iPos - 1);
                        else email = line;

                        DatabaseLayer.Contacts objContact = new DatabaseLayer.Contacts();
                        objContact.USERID = Int32.Parse(Session["userID"].ToString());
                        objContact.EMAIL = email;

                        objContact.PREFIX = "";
                        objContact.LASTNAME = "";
                        objContact.FIRSTNAME = "";
                        objContact.SUFFIX = "";

                        objContact.ADDRESS1 = "";
                        objContact.ADDRESS2 = "";

                        objContact.CITY = "";
                        objContact.PROVINCE = "";
                        objContact.ZIP = "";

                        objContact.BUSINESSNAME = "";
                        objContact.PHONE = "";
                        objContact.FAX = "";

                        objContact.CONFIRMED = true;
                        objContact.SENDEMAIL = true;
                        objContact.CONFIRMCODE = Guid.NewGuid().ToString().Replace("-", "");


                        int iContactID = objContact.IsExistContactEmail();

                        if (iContactID==0)
                        {
                            iContactID = objContact.Insert();
                        }

                        
                        if (iContactID > 0)
                        {
                            //insert contact_list
                            string[] listIDs;
                            if (Request.QueryString["listid"].Equals(""))
                            {
                                listIDs = strListSelected.Split(',');
                            }
                            else {
                                listIDs = new string[1];
                                listIDs[0] = Request.QueryString["listid"];
                            }

                            
                            foreach (string strID in listIDs)
                            {
                                DatabaseLayer.Contact_list objContactList = new DatabaseLayer.Contact_list();
                                objContactList.CONTACTID = iContactID;
                                objContactList.LISTID = Int32.Parse(strID);
                                objContactList.SUBSCRIBES = true;

                                objContactList.Insert();

                            }

                        }


                    }//end while

                    

                    //update total subscribes in contact list table
                    string[] listIDs1;
                    if (Request.QueryString["listid"].Equals(""))
                    {
                        listIDs1 = strListSelected.Split(',');
                    }
                    else
                    {
                        listIDs1 = new string[1];
                        listIDs1[0] = Request.QueryString["listid"];
                    }

                    foreach (string strID in listIDs1)
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

                    System.Web.UI.HtmlControls.HtmlGenericControl noticeContentDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                    noticeContentDiv.ID = "infoDivCode";
                    noticeContentDiv.Style.Add("position", "relative");
                    noticeContentDiv.Style.Add("margin", "20px auto");
                    noticeContentDiv.Style.Add("padding", "20px 0px 0px 80px");
                    noticeContentDiv.Style.Add("width", "520px");
                    noticeContentDiv.Style.Add("height", "40px");
                    noticeContentDiv.Style.Add("color", "#000000");
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
                    noticeContentDiv.Style.Add("background-image", "url(../../img/check.png)");
                    noticeContentDiv.InnerHtml = "Contacts are successful imported into " + Convert.ToString(listIDs1.Length) + " list(s)";
                    infoDiv.Controls.Add(noticeContentDiv);

                }
            }
            else
            {
                lblMsg.Text = "Please select aleast 1 list.<br/>";
            }
            
            
        }

    }

}
