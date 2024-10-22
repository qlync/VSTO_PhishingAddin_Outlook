using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace PhishingReportAddin
{
    public partial class PhishingReportForm : Form
    {
        private Outlook.MailItem selectedMailItem;

        public PhishingReportForm(Outlook.MailItem mailItem)
        {
            InitializeComponent();
            selectedMailItem = mailItem;
            this.Font = new System.Drawing.Font("Segoe UI", 9);
            this.BackColor = System.Drawing.Color.White;
        }
        private void reportButton_Click(object sender, EventArgs e)
        {
            StringBuilder reportDetails = new StringBuilder();

            if (spamCheckBox.Checked)
                reportDetails.AppendLine("Received spam email.");

            if (phishingCheckBox.Checked)
                reportDetails.AppendLine("Received a phishing email.");

            if (notSureCheckBox.Checked)
                reportDetails.AppendLine("Not sure this is a legitimate email.");

            if (!string.IsNullOrEmpty(additionalInfoTextBox.Text) && additionalInfoTextBox.Text != "Type here")
                reportDetails.AppendLine("Additional information: " + additionalInfoTextBox.Text);

            if (SendMailToSecurityDepartment(reportDetails.ToString()))
            {
                DeleteOriginalEmail();
            }

            this.Close();
        }
        private void additionalInfoTextBox_Enter(object sender, EventArgs e)
        {
            if (additionalInfoTextBox.Text == "Type here")
            {
                additionalInfoTextBox.Text = "";
                additionalInfoTextBox.ForeColor = Color.Black;
            }
        }
        private void additionalInfoTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(additionalInfoTextBox.Text))
            {
                additionalInfoTextBox.Text = "Type here";
                additionalInfoTextBox.ForeColor = Color.Gray;
            }
        }

        private void dontReportButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool SendMailToSecurityDepartment(string reportDetails)
        {
            try
            {
                Outlook.Application outlookApp = new Outlook.Application();
                Outlook.MailItem newMail = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);

                newMail.Subject = "Phishing Report";
                newMail.To = Properties.Settings.Default.EmailAddress;
                newMail.Body = reportDetails;

                newMail.Attachments.Add(selectedMailItem);

                newMail.Send();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
                return false;
            }
        }
        private void DeleteOriginalEmail()
        {
            try
            {
                selectedMailItem.Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting email: " + ex.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PhishingReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
