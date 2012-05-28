using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

	using System.Configuration;
	using System.Diagnostics;

using ZetaSpamAssassin;
namespace EmailSite.Test
{
    public partial class TestSpamCheckerPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs ee)
        {
            SpamAssassinProtocol sap = new SpamAssassinProtocol(
                ConfigurationManager.AppSettings["spamAssassinServerName"]);

            if (true)
            {
                SpamAssassinCheckArgs e = new SpamAssassinCheckArgs();
                e.TextToCheck = TextBox1.Text;

                SpamAssassinCheckResult r = sap.ExecuteCheck(e);
                TextBox2.Text += "/n" + "IsSpam: " + r.IsSpam;
                TextBox2.Text += "/n" + "IsSpam: " + r.IsSpam;
                TextBox2.Text += "/n" + "Score: " + r.Score;
                TextBox2.Text += "/n" + "Threshold: " + r.Threshold;
            }

            if (true)
            {
                SpamAssassinPingArgs e = new SpamAssassinPingArgs();

                SpamAssassinPingResult r = sap.ExecutePing(e);
            }

            if (true)
            {
                SpamAssassinProcessArgs e = new SpamAssassinProcessArgs();
                e.TextToCheck = TextBox1.Text;

                SpamAssassinProcessResult r = sap.ExecuteProcess(e);

                TextBox2.Text += "/n" + "ProcessedMessage: " + r.ProcessedMessage;
            }

            if (true)
            {
                SpamAssassinReportArgs e = new SpamAssassinReportArgs();
                e.TextToCheck = TextBox1.Text;

                SpamAssassinReportResult r = sap.ExecuteReport(e);

                TextBox2.Text += "/n" + "IsSpam: " + r.IsSpam;
               TextBox2.Text += "/n" + "Score: " + r.Score;
                TextBox2.Text += "/n" + "Threshold: " + r.Threshold;
                TextBox2.Text += "/n" + "ReportedText: " + r.ReportText;
            }

            if (true)
            {
                SpamAssassinReportIfSpamArgs e = new SpamAssassinReportIfSpamArgs();
                e.TextToCheck = TextBox1.Text;

                SpamAssassinReportIfSpamResult r = sap.ExecuteReportIfSpam(e);

                TextBox2.Text += "/n" + "IsSpam: " + r.IsSpam;
                TextBox2.Text += "/n" + "Score: " + r.Score;
                TextBox2.Text += "/n" + "Threshold: " + r.Threshold;
                TextBox2.Text += "/n" + "ReportText: " + r.ReportText;
            }

            if (true)
            {
                SpamAssassinSkipArgs e = new SpamAssassinSkipArgs();

                SpamAssassinSkipResult r = sap.ExecuteSkip(e);
            }

            if (true)
            {
                SpamAssassinSymbolsArgs e = new SpamAssassinSymbolsArgs();
                e.TextToCheck = TextBox1.Text;

                SpamAssassinSymbolsResult r = sap.ExecuteSymbols(e);

                TextBox2.Text += "/n" + "IsSpam: " + r.IsSpam;
                TextBox2.Text += "/n" + "Score: " + r.Score;
                TextBox2.Text += "/n" + "Threshold: " + r.Threshold;

                if (r.SymbolLines != null)
                {
                    foreach (string symbolLine in r.SymbolLines)
                    {
                        TextBox2.Text += "/n" + "Symbol line: " + symbolLine;
                    }
                }
            }

            if (true)
            {
                SpamAssassinTellArgs e = new SpamAssassinTellArgs();
                e.TextToCheck = TextBox1.Text;

                e.Action = SpamAssassinTellArgs.TellAction.ForgetLearnedMessage;

                SpamAssassinTellResult r = sap.ExecuteTell(e);

                TextBox2.Text += "/n" + "DidSet: " + r.DidSet;
                TextBox2.Text += "/n" + "DidRemove: " + r.DidRemove;
            }
        }
    }
}