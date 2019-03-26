using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace TestForgotPassword
{
    public class EmailSender : IEmailSender
    {
        string host = "smtp.mail.ru";
        int port = 587;
        bool enableSSL = true;
        string userName = "gap.international@bk.ru";
        string password = "ArmanDanielyan";

        //public EmailSender(string host, int port, bool enableSSL, string userName, string password)
        //{
        //    this.host = host;
        //    this.port = port;
        //    this.enableSSL = enableSSL;
        //    this.userName = userName;
        //    this.password = password;
        //}

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential(userName, password),
                EnableSsl = enableSSL
            };
            return client.SendMailAsync(
                new MailMessage(userName, email, subject, htmlMessage) { IsBodyHtml = true }
            );
        }
    }
}
