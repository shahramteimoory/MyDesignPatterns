using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoratoe_Wrapper.Example2
{
    public class SendEmail
    {
        public void Send()
        {
            Console.WriteLine("Email Sended....!");
        }
    }
    public class SendEmailDecorator:SendEmail
    {
        private readonly SendEmail _sendEmail;
        public SendEmailDecorator(SendEmail send)
        {
            _sendEmail=send;
        }
        public void send()
        {
            _sendEmail.Send();
            SaveLog();
        }
        private void SaveLog()
        {
            Console.WriteLine("Save Log....");
        }
    }
}
