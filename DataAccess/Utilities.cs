using System;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace DataAccess
{
    public static class Utilities
    {
        static Utilities()
        {

        }

        public static void SendMail(string from, string to, string subject, string body)
        {
            SmtpClient mailClient = new SmtpClient(GiftShopConfiguration.MailServer);
            mailClient.Credentials = new NetworkCredential(GiftShopConfiguration.MailUsername, GiftShopConfiguration.MailPassword);

            MailMessage mailMessage = new MailMessage(from, to, subject, body);

            mailClient.Send(mailMessage);
        }

        public static void LogError(Exception ex)
        {
            string dateTime = DateTime.Now.ToLongDateString() + ", at " + DateTime.Now.ToShortTimeString();

            StringBuilder errorMessage = new StringBuilder();

            errorMessage.AppendLine("Exception generated on " + dateTime);

            System.Web.HttpContext context = System.Web.HttpContext.Current;

            errorMessage.AppendLine();
            errorMessage.AppendLine("Page location: " + context.Request.RawUrl);

            errorMessage.AppendLine();
            errorMessage.AppendLine("Message: " + ex.Message);
            errorMessage.AppendLine();
            errorMessage.AppendLine("Source: " + ex.Source);
            errorMessage.AppendLine();
            errorMessage.AppendLine("Method: " + ex.TargetSite);
            errorMessage.AppendLine();
            errorMessage.AppendLine("Stack Trace: ");
            errorMessage.AppendLine(ex.StackTrace);

            if (GiftShopConfiguration.EnableErrorLogEmail)
            {
                string from = GiftShopConfiguration.MailFrom;
                string to = GiftShopConfiguration.ErrorLogEmail;
                string subject = "GiftShop Error Report";
                string body = errorMessage.ToString();

                SendMail(from, to, subject, body);
            }

            WriteLogFile(errorMessage.ToString());
        }

        public static void WriteLogFile(string errorMessage)
        {
            string date = DateTime.Now.ToShortDateString();
            date = date.Replace('/', '-');

            string directoryPath = @"C:\inetpub\wwwroot\GiftShopLogs\" + date;

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = directoryPath + @"\ErrorLog.txt";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****************************************************************************************************");
            sb.AppendLine();
            sb.AppendLine(errorMessage);
            sb.AppendLine();
            sb.AppendLine("****************************************************************************************************");
            sb.AppendLine();
            sb.AppendLine();

            File.AppendAllText(filePath, sb.ToString());
        }
    }
}
