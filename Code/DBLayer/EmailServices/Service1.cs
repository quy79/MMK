using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Web;

using DatabaseLayer;
using System.Data.SqlClient;
using ChilkatEmail.Utils;
using ChilkatEmail;
using System.Collections;
namespace EmailServices
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        
        protected override void OnStart(string[] args)
        {
            base.OnStart(args);

            
           // while (/*SERVICE_TO*/ true)
            {
                Debug.WriteLine("start auto responder");
                
                DBManager.initConnection();
                Thread.Sleep(30000);
                Thread t = new Thread(MainTHreadLoop);
                t.Start();
                Debug.WriteLine("end onstart");
            }
        }

        protected void MainTHreadLoop()
        {
            Thread autoEnginThread = new Thread(OnStartMain);
            autoEnginThread.Start();
            //Thread.Sleep(600 * 1000);
            Thread sendMailThread = new Thread(OnSendMail);
            sendMailThread.Start();
            while(true){
                Thread.Sleep(3600*1000);
                if (!autoEnginThread.IsAlive)
                {
                    autoEnginThread = new Thread(OnStartMain);
                    autoEnginThread.Start();
                }
               if (!sendMailThread.IsAlive)
                {
                    sendMailThread = new Thread(OnSendMail);
                    sendMailThread.Start();
                }
            }

        }
       
        protected  void OnStartMain()
        {
          
             ArrayList list = new ArrayList();
             while (SERVICE_TOP)
             {
                 try
                 {
                     Debug.WriteLine("Enter Do loop all auto responder and check each auto responder");
                     Debug.WriteLine("Check and generate table auto-pending");

                     generate_auto_table_pending();

                     Debug.WriteLine("Check and generate table auto-pending: DONE");
                     Autoresponder autoresponder = new Autoresponder();
                     DataTable dtAutoResponder = autoresponder.Select();
                     foreach (DataRow row in dtAutoResponder.Rows)
                     {
                         int auID = int.Parse(row["ID"].ToString());
                         //[STATUS] = 0:Stop; 1:just created not init; 2: stated; 4: finished
                         //
                         int duration = int.Parse(row[8].ToString());
                         Autoresponder_messages_detail auto_detail = new Autoresponder_messages_detail();
                         auto_detail.AUTORESPONDERID = auID;
                         DataTable auto_detail_table = auto_detail.Select();
                         bool passedEndDate = false;
                         foreach (DataRow aU_DE_row in auto_detail_table.Rows)
                         {
                             String temp_enddate = aU_DE_row[4].ToString();
                             int status = int.Parse(aU_DE_row[3].ToString());
                             if (!string.IsNullOrEmpty(temp_enddate))
                             {
                                 DateTime endDate = DateTime.Parse(aU_DE_row[4].ToString());
                                 passedEndDate = checkENDDATEPassedCurrentDate(endDate, duration);
                             }
                             // Check each message in each autoresponder
                             // if it does not init or finished and passed the time line

                             if (status == 2 || (passedEndDate && status == 4))
                             {
                                 //Create thead
                                 Thread t = new Thread(newAutoResponderSendMessageToContactListThread);
                                 t.Start(aU_DE_row);
                                 list.Add(t);
                             }
                             // check available thread
                             for (int i = list.Count; i > 0; i--)
                             {
                                 Thread item = (Thread)list[i - 1];
                                 if (item == null || !item.IsAlive)
                                 {
                                     Thread t = new Thread(newAutoResponderSendMessageToContactListThread);
                                     t.Start(aU_DE_row);
                                     list.Add(t);
                                     list.RemoveAt(i - 1);
                                 }
                                 else
                                 {
                                     Debug.WriteLine("new thread is running");
                                 }
                             }


                         }
                     }



                     Debug.WriteLine("new thread return");
                     Debug.WriteLine("Beggin Sleep");
                     Thread.Sleep(60000);
                     Debug.WriteLine("End Sleep");
                 }
                 catch (Exception ee)
                 {
                     Debug.WriteLine(ee);
                 }

             }
            
        }

        protected override void OnStop()
        {
           // DBManager.CloseConnection();

            //base.Stop();
        }
        void newAutoResponderSendMessageToContactListThread(object data)
        {
            DataRow rowMessageDetail = (DataRow)data;
            bool ENDOFLOOP = false;
            Debug.WriteLine("newAutoResponderSendMessageToContactListThread autoID=" + rowMessageDetail[1].ToString() + " messageID = " + rowMessageDetail[2].ToString());
            MailServices mailSV = new MailServices();
           // Thread t = new Thread(GoSendMessagetoAutoResponder);
            //return;
            do
            {

                AutoresponderStatus autoStatus = new AutoresponderStatus();
                autoStatus.MESSAGEID = int.Parse(rowMessageDetail[2].ToString());
                autoStatus.AUTOID = int.Parse(rowMessageDetail[1].ToString());

                DataTable autoStatusTable = autoStatus.Select();

                if (autoStatusTable == null || autoStatusTable.Rows.Count == 0)
                {
                    //This auto was deleted
                    // remove this auto out auto-spending table
                    // remove this auto out the auto-status
                    return;
                }
                else
                {
                    int count = 0;
                    foreach (DataRow row in autoStatusTable.Rows)
                    {
                        int autoID = int.Parse(row[1].ToString());
                        int status = int.Parse(rowMessageDetail[3].ToString());
                        int emailID = int.Parse(row[2].ToString());
                        int totalContact = int.Parse(row[4].ToString());
                        if(status ==4){ //finish
                            ENDOFLOOP = true;
                            return;
                        }
                        int sumContact = 0;
                        if (row[5] == DBNull.Value)
                        {
                            sumContact = 0;
                        }
                        else
                        {
                            sumContact = int.Parse(row[5].ToString());
                        }
                        if (row[4] == DBNull.Value)
                        {
                            totalContact = 0;
                        }
                        else
                        {
                            totalContact = int.Parse(row[4].ToString());
                        }

                        int autoStatusID = int.Parse(row[0].ToString());

                        // inform auto table started with status =2

                        // Autoresponder_messages autoresponder_message = new Autoresponder_messages();
                        // autoresponder_message.ID = int.Parse(aU_DE_row[0].ToString());
                        //autoresponder_message.AUTORESPONDERID = auID;
                        // autoresponder_message.MESSAGEID = int.Parse(aU_DE_row[2].ToString());
                        // autoresponder_message.STATUS = 2;
                        // autoresponder_message.Update();

                        Autoresponder autoresponder = new Autoresponder();
                        autoresponder.ID = autoID;
                        DataTable autoTable = autoresponder.Select();
                        //foreach (DataRow autoRow in autoTable.Rows)
                        //{
                        // autoresponder.USERID = int.Parse(autoRow[1].ToString());
                        // autoresponder.NAME = autoRow[2].ToString();
                        // autoresponder.DESCRIPTION = autoRow[3].ToString();
                        // autoresponder.LISTID = int.Parse(autoRow[4].ToString()); ;
                        // autoresponder.FROMNAME = autoRow[5].ToString();
                        //autoresponder.FROMEMAIL = autoRow[6].ToString();
                        // autoresponder.STATUS = 2;// change to started
                        // autoresponder.MODIFIEDDATE = DateTime.Parse(autoRow[8].ToString());
                        // autoresponder.Update();
                        // }


                        if (status != 0) // not stop
                        {
                            // get message
                            Messages message = new Messages();
                            message.ID = emailID;
                            DataTable dtMessages = message.Select();
                            String from = "'" + ((DataRow)autoTable.Rows[0])[5].ToString() + "'" + "<" + ((DataRow)autoTable.Rows[0])[6].ToString() + ">";
                            string subject = "";
                            string body = "";
                           String listID=((DataRow)autoTable.Rows[0])[4].ToString() ;
                            foreach (DataRow M_row in dtMessages.Rows)
                            {
                                //from = M_row[3].ToString();
                                subject = M_row[4].ToString();
                                body = M_row[5].ToString();
                            }
                            // Select and send 50 items
                            AutoresponderPending pending = new AutoresponderPending();
                            pending.MESSAGEID = emailID;
                            pending.AUTOID = autoID;
                            DataTable pendingTable = pending.Select();
                           // List<String> listTo = new List<string>();
                            foreach (DataRow rowPending in pendingTable.Rows)
                            {
                                List<String> listTo = new List<string>();
                                String email = rowPending[4].ToString();
                                pending.ID = int.Parse(rowPending[0].ToString());
                                pending.Delete();
                                listTo.Add(email);
                                count++;
                               // if (count > ChilkatEmail.Utils.Constants.emailSentPerTime) break;
                                mailSV.AutoresponderSendEmail(from, listTo, null, null, subject, body, "" + autoID, "" + emailID , listID, rowPending[3].ToString());
                            }
                            //if (listTo.Count > 0)
                           /// {
                               // mailSV.AutoresponderSendEmail(from, null, null, listTo, subject, body,""+autoID,""+emailID
                                //    , listID,"50");
                           /// }
                            // remove from pending time;

                            // Update Status table5
                            autoStatus.AUTOID = autoID;
                            autoStatus.MESSAGEID = emailID;

                            // Check if run out of item
                            pendingTable = pending.Select();
                            if (pendingTable.Rows.Count == 0) //last item
                            {
                                autoStatus.STATUS = 4;// finish
                                // inform auto table status = 4
                                //autoresponder.STATUS = 4;

                                // set status4, enddate= currentDate in auto_message

                                // autoresponder.Update();

                                //Update auto-message table


                                Autoresponder_messages au_message = new Autoresponder_messages();
                                au_message.AUTORESPONDERID = int.Parse(rowMessageDetail[1].ToString());
                                au_message.MESSAGEID = int.Parse(rowMessageDetail[2].ToString());
                                DataTable au_message_table = au_message.Select();
                                foreach (DataRow row1 in au_message_table.Rows)
                                {
                                    // Autoresponder_messages autoresponder_message = new Autoresponder_messages();
                                    au_message.ID = int.Parse(row1[0].ToString());
                                    au_message.AUTORESPONDERID = int.Parse(row1[1].ToString()); ;
                                    au_message.MESSAGEID = int.Parse(row1[2].ToString());
                                    au_message.STATUS = 4;

                                    au_message.ENDDATE = DateTime.Now;


                                    // au_message.DURATION = int.Parse(row1[5].ToString());
                                    au_message.Update();
                                    ENDOFLOOP = true;
                                }


                            }
                            else
                            {
                                //autoStatus.STATUS = 1;
                                //Update countsendContact inauto_status with number send.
                            }
                            autoStatus.ID = autoStatusID;
                            autoStatus.TOTALCONTACT = totalContact;
                            autoStatus.SUMCONTACTSENT = sumContact + count;
                            autoStatus.Update();



                        }
                    }
                }

                Thread.Sleep(30000); // 5 minutes
                bounceMail();
                Debug.WriteLine("End new thread ");
            } while (!ENDOFLOOP);


        }

        /// <summary>
        /// Check Endate with current date to see if it passed the milestone.
        /// </summary>
        /// <param name="endate"></param>
        /// <returns></returns>
        bool checkENDDATEPassedCurrentDate(DateTime endate, int intervaldays)
        {

            DateTime currentdate = DateTime.Now;
            endate = endate.AddDays(intervaldays);
            int result = DateTime.Compare(endate, currentdate);

            if (result > 0)
                return false;
            else
                return true;
        }
        public bool SERVICE_TOP = true;
        /// <summary>
        /// 
        /// </summary>
        private void generate_auto_table_pending()
        {
            lock (this)
            {

                //  int messageID = 0;
                //1.
                Autoresponder autoresponder = new Autoresponder();
                DataTable dtAutoResponder = autoresponder.Select();
                foreach (DataRow row in dtAutoResponder.Rows)
                {
                    int auID = int.Parse(row["ID"].ToString());
                    //[STATUS] = 0:Stop; 1:just created not init; 2: stated; 3: processing 4: finished
                    //
                    int duration = int.Parse(row[8].ToString());
                    Autoresponder_messages_detail auto_detail = new Autoresponder_messages_detail();
                    auto_detail.AUTORESPONDERID = auID;
                    DataTable auto_detail_table = auto_detail.Select();
                    bool passedEndDate = false;
                    foreach (DataRow aU_DE_row in auto_detail_table.Rows)
                    {
                        String temp_enddate = aU_DE_row[4].ToString();
                        int status = int.Parse(aU_DE_row[3].ToString());
                        if (!string.IsNullOrEmpty(temp_enddate))
                        {
                            DateTime endDate = DateTime.Parse(aU_DE_row[4].ToString());
                            passedEndDate = checkENDDATEPassedCurrentDate(endDate, duration);
                        }
                        // Check each message in each autoresponder
                        // if it does not init or finished and passed the time line

                        if (status == 1 || (passedEndDate && status == 4))
                        {
                            DataTable dtContactList;
                            int mID = int.Parse(aU_DE_row[2].ToString());
                            //3.
                            if (aU_DE_row[9].ToString().Equals("1"))
                            {
                                int userID = int.Parse(aU_DE_row[1].ToString());
                                dtContactList = GetContactsFromSegment(userID, int.Parse(row[4].ToString()), true);
                            } else{
                                Contact_list contactList = new Contact_list();
                                contactList.CONTACTID = -1;
                                contactList.LISTID = int.Parse(row[4].ToString());
                                contactList.SUBSCRIBES = true;
                                dtContactList = contactList.Select();
                            }
                            
                            int totalContacts = 0;
                            foreach (DataRow rowContacts in dtContactList.Rows)
                            {
                                int contactID = int.Parse(rowContacts[0].ToString());
                                String email = rowContacts[3].ToString();
                                // Save to auto-pending table
                                AutoresponderPending pendingTable = new AutoresponderPending();
                                pendingTable.AUTOID = auID;
                                pendingTable.MESSAGEID = mID;
                                pendingTable.CONTACTID = contactID;
                                pendingTable.EMAIL = email;
                                pendingTable.STATUS = 1; //init
                                pendingTable.Insert();
                                totalContacts++;


                            }

                            
                            // Change status so that we know the message of the auto is processing.
                            Autoresponder_messages autoresponder_message = new Autoresponder_messages();
                            autoresponder_message.ID = int.Parse(aU_DE_row[0].ToString());
                            autoresponder_message.AUTORESPONDERID = auID;
                            autoresponder_message.MESSAGEID = int.Parse(aU_DE_row[2].ToString());
                            if (totalContacts > 0)
                            {
                                autoresponder_message.STATUS = 2;
                            }
                            else
                            {
                                autoresponder_message.STATUS = 4;
                                autoresponder_message.ENDDATE = DateTime.Now;
                            }
                            if (aU_DE_row[4] == DBNull.Value)
                            {
                                // autoresponder_message.ENDDATE = null;
                            }
                            else
                            {
                                autoresponder_message.ENDDATE = DateTime.Parse(aU_DE_row[4].ToString());
                            }

                            //autoresponder_message.DURATION = int.Parse(aU_DE_row[5].ToString());
                            autoresponder_message.Update();


                            // Insert into Autoresponder_Status
                            AutoresponderStatus autoStatus = new AutoresponderStatus();
                            autoStatus.AUTOID = autoresponder_message.AUTORESPONDERID;
                            if (totalContacts > 0)
                            {
                                autoStatus.STATUS = 2;
                            }
                            else
                            {
                                autoStatus.STATUS = 4;
                               

                            }
                            
                            autoStatus.MESSAGEID = autoresponder_message.MESSAGEID;
                            autoStatus.TOTALCONTACT = totalContacts;
                            autoStatus.SUMCONTACTSENT = 0;
                            autoStatus.Delete();
                            autoStatus.Insert();


                        }



                    }

                }
            }





        }
        void bounceMail()
        {
            Chilkat.MailMan mailman = new Chilkat.MailMan();
            bool success = mailman.UnlockComponent(ChilkatEmail.Utils.Constants.ChilkatEmailUnlock);
            mailman.MailHost = ChilkatEmail.Utils.Constants.strSmtpHost;
            mailman.PopUsername = ChilkatEmail.Utils.Constants.bounceEmailAddress;
            mailman.MailPort = 110;
            mailman.PopPassword = ChilkatEmail.Utils.Constants.bounceEmailPassword;

            Chilkat.Bounce bounce = new Chilkat.Bounce();
            success = bounce.UnlockComponent(ChilkatEmail.Utils.Constants.ChilkatBounceUnlock);
            if (!success)
            {
                Debug.WriteLine(bounce.LastErrorText);
                return;
            }

            // Read email from the POP3 server.
            Chilkat.EmailBundle bundle;
            bundle = mailman.CopyMail();
            if (bundle != null)
            {
                // Loop over each email...
                Chilkat.Email email;
                int i;
                // bool success;
                for (i = 0; i < bundle.MessageCount; i++)
                {
                    email = bundle.GetEmail(i);

                    String error = "";
                    // See if this is a bounced email.
                    // This sets the properties of the Bounce object
                    success = bounce.ExamineEmail(email);
                    if (!success)
                        error="Failed to classify email";
                    else if (bounce.BounceType == 1)
                        // Hard bounce, log the email address
                        error="Hard Bounce: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 2)
                        // Soft bounce, log the email address
                        error="Soft Bounce: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 3)
                        // General bounce, no email address available.
                        error="General Bounce: No email address";
                    else if (bounce.BounceType == 4)
                        // General bounce, log the email address
                       error="General Bounce: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 5)
                        // Mail blocked, log the email address
                       error="Mail Blocked: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 6)
                        // Auto-reply, log the email address
                       error="Auto-Reply: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 7)
                        // Transient (recoverable) Failure, log the email address
                       error="Transient Failure: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 8)
                        // Subscribe request, log the email address
                       error="Subscribe Request: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 9)
                        // Unsubscribe Request, log the email address
                       error="Unsubscribe Request: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 10)
                        // Virus Notification, log the email address
                       error="Virus Notification: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 11)
                        // Suspected bounce.
                        // This should be rare.  It indicates that the Bounce
                        // component found strong evidence that this is a bounced
                        // email, but couldn//t quite recognize everything it
                        // needed to be 100% sure.  Feel free to notify
                        // support@chilkatsoft.com regarding emails having this
                        // bounce type.
                       error="Suspected Bounce!";
                    Bounce b = new Bounce();
                    b.AUTORESPONDERID = 0;
                    b.MESSAGEID = 0;
                    b.LISTID = 0;
                    b.BOUNCEMESSAGE = error;
                    b.EMAIL = bounce.BounceAddress;
                    b.DATEBOUNCE = DateTime.Now;
                    b.Insert();
                    bundle.RemoveEmail(email);
                    email = null;
                }
                bundle = null;
            }
            mailman = null;
        }

        protected void OnSendMail()
        {
            MailServices mailSV = new MailServices();
            while (true)
            {
                try
                {
                    Contact_message ct = new Contact_message();
                    DataTable tb = ct.Select();


                    foreach (DataRow row in tb.Rows)
                    {
                        int ctID = int.Parse(row[0].ToString());
                        int messageID = int.Parse(row[1].ToString());
                        String email = row[4].ToString();
                        String messageName = row[2].ToString();
                        String emailfrom = row[3].ToString();
                        String subject = row[5].ToString();
                        String body = row[6].ToString();
                        int listID = int.Parse(row[7].ToString());
                        ct.CONTACTID = ctID;
                        ct.MESSAGEID = messageID;
                        ct.LISTID = listID;
                        ct.Delete();
                        List<String> emailList = new List<string>();
                        emailList.Add(email);
                        mailSV.SendHTMLEmailToListContact(emailfrom, emailList, null, null,listID+"",ctID+"",messageID+"", subject, body);

                    }
                    Thread.Sleep(5 * 60 * 1000);
                }catch (Exception ee){
                }
            }
        }
        public DataTable GetContactsFromSegment(int userID,int segID, bool subcribes)
        {
            try
            {
               // string sub = (subcribes) ? "1" : "0";
                string strQuery = "select distinct CL.CONTACTID,CL.LISTID,CL.SUBSCRIBES,CT.EMAIL from CONTACTS CT INNER JOIN CONTACT_LIST cl ON ct.ID = cl.CONTACTID WHERE ct.USERID = " + userID + " AND CL.SUBSCRIBES=1 ";

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
    }
}
