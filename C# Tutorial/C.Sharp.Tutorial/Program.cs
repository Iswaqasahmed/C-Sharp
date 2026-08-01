using MailKit.Security;
using MimeKit;
using System;

namespace C.Sharp.Tutorial
{
    public class Program
    {
        static void Main(string[] args)
        {





            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Test", "manas@pk.gt.com"));
            message.To.Add(new MailboxAddress("You", "your-email@example.com"));
            message.Subject = "SMTP Test";
            message.Body = new TextPart("plain")
            {
                Text = "SMTP test successful."
            };

             var client = new System.Net.Mail.SmtpClient();

            try
            {
                client.Connect("eu-test.com", 587, SecureSocketOptions.StartTls);
                client.Authenticate("manas@pk.gt.com", "YOUR_SMTP_PASSWORD");

                client.Send(message);
                client.Disconnect(true);

                Console.WriteLine("Email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





            //Encapsulation.Encapsulation ec = new Encapsulation.Encapsulation();

            socket.Client sck = new socket.Client();
            sck.client();
            //socket.Server sck = new socket.Server();
            //sck.Recieved();
            Console.ReadKey();
        }
    }
}
