using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace SMTPMail
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sendcomplete;
            string userName = "";
            string password = "";
            MailMessage outgoingMessage = new MailMessage();
            outgoingMessage.To.Add("2313605258@messaging.sprintpcs.com");
            outgoingMessage.From = new MailAddress("", "");
            outgoingMessage.Body = "This was sent from a C# Program.";

            SmtpClient smtpGoogle = new SmtpClient("smtp.gmail.com");
            smtpGoogle.EnableSsl = true;
            smtpGoogle.Port = 587;
            smtpGoogle.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpGoogle.Credentials = new NetworkCredential(userName,password);

            try
            {
                smtpGoogle.Send(outgoingMessage);

            }
            catch(Exception ex)
            {
                Console.WriteLine("{0}", ex.Message);
            }

            Console.WriteLine("If no message showed up the mail message was likely sent.");
            Console.ReadKey(true);

        }
    }
}
