using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace CVSender
{
    public static class Email
    {
        public static void sendEmail(string msg, string sub)
        {
            var fromAddress = new MailAddress("aytekinerlale1@gmail.com", "Aytekin Erlale");
            var toAddress = new MailAddress("aytekinerlale@gmail.com");
            const string fromPassword = "";


            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("email@gmail.com");
                mail.To.Add(toAddress);
                mail.Subject = sub;
                mail.Body = msg;
                mail.IsBodyHtml = false;
                mail.Attachments.Add(new Attachment("C:\\Users\\Skranger\\Desktop\\Aytekin Erlale cv.pdf"));

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(fromAddress.Address, fromPassword);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    Console.WriteLine("Message Send");
                }
            }
        }
    }
}
