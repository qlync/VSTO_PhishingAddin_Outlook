using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Core;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;

namespace PhishingReportAddin
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.ItemSend += new ApplicationEvents_11_ItemSendEventHandler(Application_ItemSend);

        }

        private void ThisAddin_Shutdown(object sender, System.EventArgs e)
        {
            this.Application.ItemSend -= new ApplicationEvents_11_ItemSendEventHandler(Application_ItemSend);

        }

        private void Application_ItemSend(object item, ref bool Cancel)
        {
            try
            {
                MailItem mailItem = item as MailItem;
                if (mailItem != null)
                {
                    if (mailItem.Subject != null && mailItem.Subject.Contains("phishing"))
                    {
                        MessageBox.Show("You cant send mails with subject contains 'phishing'", "Sending error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Sending error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddin_Shutdown);
        }
    }
}
