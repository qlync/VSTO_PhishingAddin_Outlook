//Ribbon1.cs
//Подключение пространств имен для работы с Outlook и UI.
using System;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace PhishingReportAddin
{
    //Объявление класса Ribbon1, который будет использоваться для создания пользовательской ленты в Outlook.
    public partial class Ribbon1
    {
        //Метод, который вызывается при загрузке ленты.
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
        }

        // Обработчик события клика по кнопке "Report".
        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            //Получение выбранного письма из Outlook.
            Outlook.MailItem selectedMail = GetSelectedMailItem();

            //Проверка, было ли выбрано письмо.
            if (selectedMail != null)
            {
                //Создание формы отчета о фишинге, передавая выбранное письмо.
                PhishingReportForm reportForm = new PhishingReportForm(selectedMail);
                //Показ формы и ожидание результата.
                DialogResult result = reportForm.ShowDialog();

                //Если пользователь нажал OK, продолжаем обработку.
                if (result == DialogResult.OK)
                {
                    //Генерация текста отчета о фишинге на основе введенной информации.
                    string emailBody = GenerateEmailBody(reportForm, selectedMail);
                    //Отправка отчета о фишинге.
                    SendPhishingReport(emailBody, selectedMail);
                }
            }
            else
            {
                //Если письмо не выбрано, показываем сообщение об ошибке.
                MessageBox.Show("Please select an email before reporting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Метод для получения выбранного письма из Outlook.
        private Outlook.MailItem GetSelectedMailItem()
        {
            //Получение активного окна Outlook (обозревателя).
            Outlook.Explorer explorer = Globals.ThisAddIn.Application.ActiveExplorer();
            //Проверка, есть ли выделенные элементы.
            if (explorer.Selection.Count > 0)
            {
                //Получение первого выделенного элемента.
                object selectedItem = explorer.Selection[1];
                //Проверка, является ли выбранный элемент письмом.
                if (selectedItem is Outlook.MailItem)
                {
                    return (Outlook.MailItem)selectedItem; //Возвращаем выбранное письмо.
                }
            }
            return null; //Если письмо не выбрано, возвращаем null.
        }

        //Метод для генерации текста отчета о фишинге.
        private string GenerateEmailBody(PhishingReportForm reportForm, Outlook.MailItem mailItem)
        {
            //Создание начального текста отчета с заголовком и отправителем оригинального письма.
            string body = $"Original Message Subject: {mailItem.Subject}\n";
            body += $"Original Message Sender: {mailItem.SenderName}\n";
            body += $"Original Message Body: {mailItem.Body}\n\n";
            body += "Report Details:\n";

            //Добавление информации о фишинге, если соответствующие чекбоксы отмечены.
            if (reportForm.spamCheckBox.Checked)
                body += "- Received spam email\n";
            if (reportForm.phishingCheckBox.Checked)
                body += "- Received a phishing email\n";
            if (reportForm.notSureCheckBox.Checked)
                body += "- Not sure if this is a legitimate email\n";

            //Добавление дополнительной информации, если она была введена.
            if (!string.IsNullOrWhiteSpace(reportForm.additionalInfoTextBox.Text))
                body += $"\nAdditional Information:\n{reportForm.additionalInfoTextBox.Text}\n";

            return body; //Возвращаем сгенерированный текст отчета.
        }

        //Метод для отправки отчета о фишинге.
        private void SendPhishingReport(string emailBody, Outlook.MailItem originalMailItem)
        {
            try
            {
                //Создание нового письма для отправки отчета.
                Outlook.MailItem reportMail = (Outlook.MailItem)Globals.ThisAddIn.Application.CreateItem(Outlook.OlItemType.olMailItem);
                reportMail.Subject = "Phishing Report";
                reportMail.To = Properties.Settings.Default.EmailAddress;
                reportMail.Body = emailBody;

                //Сохранение оригинального письма во временной папке.
                originalMailItem.SaveAs(System.IO.Path.GetTempPath() + "\\OriginalEmail.msg", Outlook.OlSaveAsType.olMSG);
                //Прикрепление оригинального письма к отчету.
                reportMail.Attachments.Add(System.IO.Path.GetTempPath() + "\\OriginalEmail.msg");

                //Отправка отчета.
                reportMail.Send();

                //Удаление оригинального письма после отправки отчета.
                originalMailItem.Delete();
            }
            catch (Exception ex)
            {
                //Обработка ошибок и вывод сообщения, если не удалось отправить отчет.
                MessageBox.Show("Failed to send the phishing report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
