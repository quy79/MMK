using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Chilkat;
using ChilkatEmail.Utils;
namespace ChilkatEmail
{
   public class Email
    {
       
        private int iSmtpPort;
        private bool startTLS = true;
        private string strCharSet = "";



        #region contructor
        public  Email(string smtpHost, string smtpUser, string smtpPass, int smtpPort)
        {
           // strSmtpHost = smtpHost;
           // strSmtpUser = smtpUser;
            //strSmtpPass = smtpPass;
            //iSmtpPort = smtpPort;
        }
        #endregion

        public bool StartTLS {
            get { return startTLS; }
            set { startTLS = value; }
        }

        public string Charset
        {
            get
            {
                return strCharSet;
            }
            set
            {
                strCharSet = value;
            }
        }

        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

      
        public bool SendEmailFromWebsite(string url, string subject, string emailFrom, string emailTo)
        {
            //  The mailman object is used for receiving (POP3)
            //  and sending (SMTP) email.
            Chilkat.MailMan mailman = new Chilkat.MailMan();

            //  The MHT component can be used to convert an HTML page
            //  from a URL, file, or in-memory HTML into an email
            //  with embedded images and style sheets.
            Chilkat.Mht mht = new Chilkat.Mht();
            mht.UseCids = true;
            //  Note: This example requires licenses to both "Chilkat Email" and "Chilkat MHT".

            //  Any string argument automatically begins the 30-day trial.
            bool success;

            success = mht.UnlockComponent(Constants. ChilkatEmailUnlock);
            if (success != true) return false;
            success = mailman.UnlockComponent(Constants.ChilkatEmailUnlock);
            if (success != true) return false;

            Chilkat.Email email = null;
            email = mht.GetEmail(url);
            if (email == null) return false;

            email.Subject = subject;

            email.AddTo(emailTo, emailTo);
            email.From = emailFrom;

           // mailman.SmtpHost = strSmtpHost;
            //mailman.SmtpUsername = strSmtpUser;
            //mailman.SmtpPassword = strSmtpPass;
            mailman.SmtpPort = iSmtpPort;
            mailman.StartTLS = startTLS;

            if (Charset.Length != 0) email.Charset = Charset;

            success = mailman.SendEmail(email);
            if (success != true) return false;

            success = mailman.CloseSmtpConnection();

            return true;
        }

        private void ProcessBounceEmail()
        {
            // The Chilkat Bounce component is used to classify an email as
            // one of several types of automated replies such as bounced
            // email messages, virus warnings, out-of-office replies, etc.
            // To read email from a POP3 server, the Chilkat Mail component
            // (licensed separately) is used.
        
            string strMsg = "";

            Chilkat.MailMan mailman = new Chilkat.MailMan();
            mailman.UnlockComponent("MailUnlockCode");
            mailman.MailHost = "mail.chilkatsoft.com";
            mailman.PopUsername = "login";
            mailman.PopPassword = "password";

            Chilkat.Bounce bounce = new Chilkat.Bounce();
            bool success = bounce.UnlockComponent("BounceUnlockCode");
            if (!success)
            {
                strMsg = bounce.LastErrorText;
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
                for (i=0; i<bundle.MessageCount; i++)
                {
                    email = bundle.GetEmail(i);

                    // See if this is a bounced email.
                    // This sets the properties of the Bounce object
                    success = bounce.ExamineEmail(email);
                    if (!success)
                      strMsg = "Failed to classify email";
                    else if (bounce.BounceType == 1) 
                        // Hard bounce, log the email address
                        strMsg = "Hard Bounce: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 2) 
                        // Soft bounce, log the email address
                        strMsg = "Soft Bounce: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 3) 
                        // General bounce, no email address available.
                        strMsg = "General Bounce: No email address";
                    else if (bounce.BounceType == 4) 
                        // General bounce, log the email address
                        strMsg = "General Bounce: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 5) 
                        // Mail blocked, log the email address
                        strMsg = "Mail Blocked: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 6) 
                        // Auto-reply, log the email address
                        strMsg = "Auto-Reply: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 7) 
                        // Transient (recoverable) Failure, log the email address
                        strMsg = "Transient Failure: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 8) 
                        // Subscribe request, log the email address
                        strMsg = "Subscribe Request: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 9) 
                        // Unsubscribe Request, log the email address
                        strMsg = "Unsubscribe Request: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 10) 
                        // Virus Notification, log the email address
                        strMsg = "Virus Notification: " + bounce.BounceAddress;
                    else if (bounce.BounceType == 11) 
                        // Suspected bounce.
                        // This should be rare.  It indicates that the Bounce
                        // component found strong evidence that this is a bounced
                        // email, but couldn//t quite recognize everything it
                        // needed to be 100% sure.  Feel free to notify
                        // support@chilkatsoft.com regarding emails having this
                        // bounce type.
                        strMsg = "Suspected Bounce!";
                
                    email = null;
                    }
                bundle = null;
                }
            mailman = null;
        
        }

       

    }
}
