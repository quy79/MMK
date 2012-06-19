﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChilkatEmail.Utils;
namespace ChilkatEmail
{
   public class MailServices
    {
       List<String> listMailTo = new List<string>();
       List<String> listMailCC = new List<string>();
       List<String> listMailBCC = new List<string>();
       String mailFrom = "";
       MailUtils eUtils = new MailUtils();
       public MailServices(int test)
       {
          // for test
           mailFrom = "ndhieuvn212@yahoo.com";
           listMailTo.Add("ndhieuvn212@yahoo.com");
           listMailCC.Add("ndhieuvn212@yahoo.com");
            listMailCC.Add("quy@optlynx.com");
            listMailCC.Add("quy79vn@gmail.com");
            listMailCC.Add("lequangquy@yahoo.com");
            listMailCC.Add("quy792006@yahoo.co.jp");
           listMailCC.Add("lequangquy@ezweb.ne.jp");
           listMailCC.Add("quy792006@yahoo.co.jp");
           listMailCC.Add("hoangphucnguyen@yahoo.com");
         

       }
       public MailServices()
       {
           


       }
       private const string ChilkatEmailUnlock = "ADROCKMAILQ_ZfyZ6ApxpU84";
       /// <summary>
       /// SendMail is to send emails to a list of recipients; 
       ///
       /// </summary>
       /// <param name="emailFrom"></param>
       /// <param name="emailsTo"></param>
       /// <param name="emailsCC"></param>
       /// <param name="emailsBCC"></param>
       /// <param name="subject"></param>
       /// <param name="body"></param>
       /// <returns></returns>
        public bool SendEmail(String emailFrom, List<String> emailsTo, List<String> emailsCC, List<String> emailsBCC,string subject, string body)
        {
            this.mailFrom = emailFrom;
            this.listMailTo = emailsTo;
            this.listMailCC = emailsCC;
            this.listMailBCC = emailsBCC;
            //  The mailman object is used for receiving (POP3)
            //  and sending (SMTP) email.
            Chilkat.MailMan mailman = new Chilkat.MailMan();
           

            bool success;
            success = mailman.UnlockComponent(ChilkatEmailUnlock);
            if (success != true) return false;

            Chilkat.Email email = new Chilkat.Email();

            email.Subject = subject;
            email.Body = body;
            if (listMailTo!=null && listMailTo.Count > 0)
            {
                email.AddMultipleTo(eUtils.mailParse(listMailTo));
            }
            if (listMailCC != null && listMailCC.Count > 0)
            {
                email.AddMultipleCC(eUtils.mailParse(listMailCC));
            }
            if (listMailBCC != null && listMailBCC.Count > 0)
            {
                email.AddMultipleBcc(eUtils.mailParse(listMailBCC));
            }
            
            email.From = mailFrom;
            
           
            mailman.SmtpHost = "localhost";//Constants.strSmtpHost;
           // if (Constants.strSmtpUser != null && Constants.strSmtpUser.Length > 0)
           // {
              //  mailman.SmtpUsername = Constants.strSmtpUser;
              //  mailman.SmtpPassword = Constants.strSmtpPass;
           // }
         
            //mailman.SmtpPort = iSmtpPort;
            //mailman.StartTLS = startTLS;
            //if (Charset.Length != 0) email.Charset = Charset;

            success = mailman.SendEmail(email);
            if (success != true) return false;

            success = mailman.CloseSmtpConnection();

            return true;
        }

       
        /// <summary>
        /// SendMail is to send emails to a list of recipients; 
        ///
        /// </summary>
        /// <param name="emailFrom"></param>
        /// <param name="emailsTo"></param>
        /// <param name="emailsCC"></param>
        /// <param name="emailsBCC"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public bool SendHTMLEmail(String emailFrom, List<String> emailsTo, List<String> emailsCC, List<String> emailsBCC, string subject, string htmlBody)
        {
            this.mailFrom = emailFrom;
            this.listMailTo = emailsTo;
            this.listMailCC = emailsCC;
            this.listMailBCC = emailsBCC;
            //  The mailman object is used for receiving (POP3)
            //  and sending (SMTP) email.
            Chilkat.MailMan mailman = new Chilkat.MailMan();


            bool success;
            success = mailman.UnlockComponent(ChilkatEmailUnlock);
            if (success != true) return false;

            Chilkat.Email email = new Chilkat.Email();

            email.Subject = subject;
            email.SetHtmlBody(htmlBody);
            if (listMailTo != null && listMailTo.Count > 0)
            {
                email.AddMultipleTo(eUtils.mailParse(listMailTo));
            }
            if (listMailCC != null && listMailCC.Count > 0)
            {
                email.AddMultipleCC(eUtils.mailParse(listMailCC));
            }
            if (listMailBCC != null && listMailBCC.Count > 0)
            {
                email.AddMultipleBcc(eUtils.mailParse(listMailBCC));
            }

            email.From = mailFrom;


            mailman.SmtpHost = "localhost";// Constants.strSmtpHost;
           // mailman.SmtpUsername = Constants.strSmtpUser;
            //mailman.SmtpPassword = Constants.strSmtpPass;
            //mailman.SmtpPort = Constants.iSmtpPort;
           // mailman.StartTLS = startTLS;
            //if (Charset.Length != 0) email.Charset = Charset;

            success = mailman.SendEmail(email);
            if (success != true) return false;

            success = mailman.CloseSmtpConnection();

            return true;
        }


        //public bool SendHtmlEmail(string subject, string htmlBody)
        //{
        //    //  The mailman object is used for receiving (POP3)
        //    //  and sending (SMTP) email.
        //    Chilkat.MailMan mailman = new Chilkat.MailMan();


        //    //  Note: This example requires licenses to both "Chilkat Email" and "Chilkat MHT".
        //    //  Any string argument automatically begins the 30-day trial.
        //    bool success;
        //    success = mailman.UnlockComponent(ChilkatEmailUnlock);
        //    if (success != true) return false;

        //    Chilkat.Email email = new Chilkat.Email();

        //    email.Subject = subject;
        //    email.SetHtmlBody(htmlBody);
        //    email.AddMultipleTo(eUtils.mailParse(listMailTo));
        //    email.From = mailFrom;
        //    email.AddMultipleCC(eUtils.mailParse(listMailCC));

        //    mailman.SmtpHost = Constants.strSmtpHost;
        //    //mailman.SmtpUsername = strSmtpUser;
        //   // mailman.SmtpPassword = strSmtpPass;
        //   // mailman.SmtpPort = iSmtpPort;
        //    //mailman.StartTLS = startTLS;
        //    //if (Charset.Length != 0) email.Charset = Charset;

        //    success = mailman.SendEmail(email);
        //    if (success != true) return false;

        //    success = mailman.CloseSmtpConnection();

        //    return true;
        //}

    }
}
