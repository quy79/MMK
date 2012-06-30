﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ChilkatEmail.Utils
{
    public class MailUtils
    {
        public String mailParse(List<String> list)
        {
            String result = "";
            foreach(String item in list){
                result += ";" + item;
            }
            return result;
        }
        public String ProcessHTMLBody(String body, bool isHTML, String serverName, String autoresponderID, String messageID,String listID)
        {
            String result = "";
            if (isHTML)
            {
                List<String> templinks = FetchLinksFromSource(body);
                for (int i = 0; i < templinks.Count; i++)
                {
                    String link = templinks[i];
                    String replaceString = serverName + "/redirect.aspx?AUTORESPONDERID=" + autoresponderID + "&MESSAGEID=" + messageID + "&LISTID=" + listID + "&REDIRECTURL=" + link;
                    body = body.Replace(link, replaceString);
                }
               // Literal1.Text = a;
                result = body.Replace("</html>", "<img alt='' src='" + serverName + "/empty.jpg' />");
                result += "</html>";
            }
            else
            {
                result += "<html>";
                result += "<body>";
                result += body;
                result += "<img alt='' src='" + serverName + "/empty.jpg' />";
                result += "</body>";
                result += "</html>";
            }
            return result;
        }

        public List<String> FetchLinksFromSource(string htmlSource)
        {
            if (String.IsNullOrEmpty(htmlSource)) return null;
            List<String> links = new List<String>();
            string regexImgSrc = "\\s*(?i)href\\s*=\\s*(\"([^\"]*\")|'[^']*'|([^'\">\\s]+))";
            MatchCollection matchesImgSrc = Regex.Matches(htmlSource, regexImgSrc, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            foreach (Match m in matchesImgSrc)
            {
                string href = m.Groups[1].Value;
                links.Add(href);
            }
            return links;
        }
    }
}
