using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2.MailService
{
    public interface IMailServiceBridge
    {
        void SendEmail(string Reciver, string Title,string Message);
    }
    public class GmailService : IMailServiceBridge
    {
        public void SendEmail(string Reciver, string Title, string Message)
        {
            // Code Ersal Email
            Console.WriteLine($"Email -- {Title} Sended To -- {Reciver}-- With --** {nameof(GmailService)}**");
        }
    }
    public class YahooService : IMailServiceBridge
    {
        public void SendEmail(string Reciver, string Title, string Message)
        {
            // Code Ersal Email
            Console.WriteLine($"Email -- {Title} Sended To -- {Reciver}-- With --** {nameof(YahooService)}**");
        }
    }
    public class MyCompanyEmailService : IMailServiceBridge
    {
        public void SendEmail(string Reciver, string Title, string Message)
        {
            // Code Ersal Email
            Console.WriteLine($"Email -- {Title} Sended To -- {Reciver}-- With --** {nameof(MyCompanyEmailService)}**");
        }
    }
}
