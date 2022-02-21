using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GetPraceEth
{

    /// <summary>
    /// This class contains the logic for setting up sending a message.
    /// </summary>
    class SendMail
    {
        private static MailAddress from;
        private static MailAddress to;

        public static void MailSend(List<string> list)
        {
            from = new MailAddress("From@mail.com");
            to = new MailAddress("To@mail.com");

            using (MailMessage messeg = new MailMessage(from, to))
            {
                messeg.Subject = "Bitcoin Price";

                messeg.Body = $"{DateTime.Now.Hour}:{DateTime.Now.ToString("mm")} | Price: {list.ElementAt(0)}";
                messeg.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("To@mail.com", "ZaQ12WsX");
                smtp.EnableSsl = true;

                smtp.Send(messeg);                
            }
        }
    }
}
