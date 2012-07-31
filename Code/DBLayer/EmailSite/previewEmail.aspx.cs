using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSite
{
    public partial class previewEmail : System.Web.UI.Page
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
            if (Session["currentTextEmail"] != null)
            {
                TextMessage objMsg = (TextMessage)Session["currentTextEmail"];
                lblFrom.Text = objMsg.FromEmail;
                lblSubject.Text = objMsg.Subject;
                lblMsgName.Text = objMsg.MsgName;

                if (!objMsg.IsSegment)
                {
                    DatabaseLayer.Lists objList = new DatabaseLayer.Lists();
                    objList.ID = objMsg.ListID;
                    System.Data.DataTable dbTable = objList.SelectByID();
                    if (dbTable.Rows.Count > 0) lblListName.Text = dbTable.Rows[0]["LISTNAME"].ToString();
                }
                else
                {
                    DatabaseLayer.Segment objSeg = new DatabaseLayer.Segment();
                    objSeg.ID = objMsg.ListID;
                    System.Data.DataTable dbTable = objSeg.SelectBySegmentID();
                    if (dbTable.Rows.Count > 0) lblListName.Text = dbTable.Rows[0]["NAME"].ToString();
                }


                
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //clear session
            Session["currentTextEmail"] = null;
            Response.Redirect("createMsg.aspx");
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (Session["currentTextEmail"] != null)
            {
                TextMessage dtMsg = (TextMessage)Session["currentTextEmail"];

                DatabaseLayer.Messages objMsg = new DatabaseLayer.Messages();
                objMsg.USERID = Int32.Parse(Session["userID"].ToString());
                objMsg.FROM = dtMsg.FromEmail;
                objMsg.SUBJECT = dtMsg.Subject;
                objMsg.MESSAGENAME = dtMsg.MsgName;
                objMsg.BODY = dtMsg.MsgBody;
                objMsg.STATUS = 1;
                objMsg.LISTID = dtMsg.ListID;
                objMsg.ISSEGMENT = dtMsg.IsSegment;
                objMsg.TYPE = dtMsg.TypeMsg;
                int idMsg = objMsg.InsertWithoutAutoResponder();
                DatabaseLayer.Messages oMsgs = new DatabaseLayer.Messages();
               //is list --> add contact in ListID to Contact_MessageSent table
                if (!objMsg.ISSEGMENT)
                    oMsgs.InsertContact_MessageSent(dtMsg.ListID, dtMsg.IsSegment, idMsg);
                else
                {
                    try {
                    //get contacts from list and add to contact_messageSent.
                    string strSql = "select distinct ct.ID from CONTACTS ct INNER JOIN CONTACT_LIST cl ON ct.ID = cl.CONTACTID WHERE ct.USERID = " + Session["userID"].ToString() + " AND ( cl.SUBSCRIBES = 1 ) ";
                    DatabaseLayer.SegmentCriterias objSegCri = new DatabaseLayer.SegmentCriterias();
                    objSegCri.SEGMENTID =  objMsg.LISTID;
                    DataTable dtSegCri = objSegCri.SelectBySegmentID();
                    foreach (DataRow row in dtSegCri.Rows)
                    {
                        strSql += "AND " + row["CONDITION"].ToString();
                    }

                    DatabaseLayer.Contacts objContacts = new DatabaseLayer.Contacts();
                    DataTable objTable = objContacts.ExecuteSql(strSql);
                    
                    foreach (DataRow row in objTable.Rows)
                    {
                        int contactID = Int32.Parse(row["ID"].ToString());
                        oMsgs.InsertContact_MessageSent2(contactID, dtMsg.ListID, dtMsg.IsSegment, idMsg);
                    }

                    } catch{}
                }

                Response.Redirect("createMsgDone.aspx?listid=" + dtMsg.ListID.ToString());
                

                Session["currentTextEmail"] = null;
                Response.Redirect("createMsgDone.aspx");
                
            }
        }
    }
}