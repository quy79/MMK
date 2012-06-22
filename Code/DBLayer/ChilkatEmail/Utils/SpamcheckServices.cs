using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Net;


namespace ChilkatEmail.Utils
{
    public class SpamcheckServices
    {
      /// public delegate void UploadCompletedEventHandler(object sender, UploadDataCompletedEventArgs e);
       // public event UploadCompletedEventHandler UploaMessagedSpamCompleted;
        public delegate void XMLSpamPareCompletedEventHandler(float spamRawCore, float spamCoreDetail, String spamDescription, string spamDetailDescription);
        public event XMLSpamPareCompletedEventHandler CheckSpamCompleted;
        
        public void SpamTextBeginChecking(String message)
        {
            WebClient wc = new WebClient();

            String url = "https://app.sandbox.icontact.com/icp/a/413391/c/124736/messages";

            wc.Headers["Accept"] = "text/xml";
            wc.Headers["Content-Type"] = "text/xml";
            wc.Headers["Api-Version"] = "2.2";

            wc.Headers["Api-AppId"] = "ltg5HJlubhBMf8iuzs08giCary5ZtnYF";
            wc.Headers["Api-Password"] = "zxcvbnm,./";
            wc.Headers["Api-Username"] = "hieu";

            byte[] byteArray = System.Text.Encoding.ASCII.GetBytes(
                "<messages>" +
                    "<message>" +
                        "<campaignId>136678</campaignId>" +
                        "<subject>Check Spam</subject>" +
                        "<messageType>normal</messageType>" +
                        "<messageName>Conference Invite</messageName>" +
                        "<textBody>" + message + "</textBody>" +
                    "</message>" +
                "</messages>"
                );


            wc.UploadDataCompleted += new UploadDataCompletedEventHandler(wc_UploadDataCompleted);
            wc.UploadDataAsync(new Uri(url), "POST", byteArray);
        }

        public void SpamHTMLChecking(String HTMLmessage)
        {
            WebClient wc = new WebClient();

            String url = "https://app.sandbox.icontact.com/icp/a/413391/c/124736/messages";

            wc.Headers["Accept"] = "text/xml";
            wc.Headers["Content-Type"] = "text/xml";
            wc.Headers["Api-Version"] = "2.2";

            wc.Headers["Api-AppId"] = "ltg5HJlubhBMf8iuzs08giCary5ZtnYF";
            wc.Headers["Api-Password"] = "zxcvbnm,./";
            wc.Headers["Api-Username"] = "hieu";

            byte[] byteArray = System.Text.Encoding.ASCII.GetBytes(
                "<messages>" +
                    "<message>" +
                        "<campaignId>136678</campaignId>" +
                        "<subject>Check Spam</subject>" +
                        "<messageType>normal</messageType>" +
                        "<messageName>Conference Invite</messageName>" +
                        "<htmlBody><![CDATA[<p>" + HTMLmessage + "</p>]]></htmlBody>" +
                    "</message>" +
                "</messages>"
                );


            //wc.UploadDataCompleted += new UploadDataCompletedEventHandler(wc_UploadDataCompleted);
            wc.UploadData(new Uri(url), "POST", byteArray);
        }

        public void SpamHTMLBeginChecking(String HTMLmessage)
        {
            WebClient wc = new WebClient();

            String url = "https://app.sandbox.icontact.com/icp/a/413391/c/124736/messages";

            wc.Headers["Accept"] = "text/xml";
            wc.Headers["Content-Type"] = "text/xml";
            wc.Headers["Api-Version"] = "2.2";

            wc.Headers["Api-AppId"] = "ltg5HJlubhBMf8iuzs08giCary5ZtnYF";
            wc.Headers["Api-Password"] = "zxcvbnm,./";
            wc.Headers["Api-Username"] = "hieu";

            byte[] byteArray = System.Text.Encoding.ASCII.GetBytes(
                "<messages>" +
                    "<message>" +
                        "<campaignId>136678</campaignId>" +
                        "<subject>Check Spam</subject>" +
                        "<messageType>normal</messageType>" +
                        "<messageName>Conference Invite</messageName>" +
                        "<htmlBody><![CDATA[<p>" + HTMLmessage + "</p>]]></htmlBody>" +
                    "</message>" +
                "</messages>"
                );

            
            wc.UploadDataCompleted += new UploadDataCompletedEventHandler(wc_UploadDataCompleted);
            wc.UploadDataAsync(new Uri(url), "POST", byteArray);
        }

        void wc_UploadDataCompleted(object sender, UploadDataCompletedEventArgs e)
        {
           // if (UploaMessagedSpamCompleted!=null)
           //// {
              //  UploaMessagedSpamCompleted(sender,e);
            //}
            float core = 0;
            float coreDetail = 0;
            string spamDes = "";
            string spamDetailDes = "";
            Encoding enc8 = Encoding.UTF8;
            String xmlContent = enc8.GetString(e.Result);
            XDocument document = XDocument.Parse(xmlContent);

            XElement xChile = document.Root;
            XElement messages = xChile.Element("messages");
            foreach (XElement child in messages.Elements())
            {


                if (child.Name == "message")
                {
                    foreach (XElement childMessage in child.Elements())
                    {
                        if (childMessage.Name == "spamCheck")
                        {
                            foreach (XElement childSpame in childMessage.Elements())
                            {
                                if (childSpame.Name == "rawScore")
                                {
                                    core = float.Parse(childSpame.Value.ToString());
                                }
                                if (childSpame.Name == "spamDetails")
                                {
                                    XElement childSpamDetails = childSpame.Element("spamDetail");
                                    if (childSpamDetails != null)
                                    {
                                        foreach (XElement childSpamDetail in childSpamDetails.Elements())
                                        {
                                            if (childSpamDetail.Name == "spamDetailScore")
                                            {
                                                coreDetail = float.Parse(childSpamDetail.Value.ToString());
                                            }
                                            if (childSpamDetail.Name == "spamDetailName")
                                            {
                                                spamDes = childSpamDetail.Value.ToString();
                                            }
                                            if (childSpamDetail.Name == "spamDetailDescription")
                                            {
                                                spamDetailDes = childSpamDetail.Value.ToString();
                                            }

                                        }
                                    }

                                }



                            }

                        }


                    }


                }
               

            }

            if (CheckSpamCompleted != null)
            {
                CheckSpamCompleted(core, coreDetail, spamDes, spamDetailDes);
            }
        }



        
    }

        
}          
    

