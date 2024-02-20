using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2.MailService
{
    public abstract class MailServiceAbstractions
    {
        private readonly IMailServiceBridge _MailService;
        public MailServiceAbstractions()
        {
            _MailService =Implementation.MailServiceBridge();
        }
        public virtual void Send(EmailInformationDto email)
        {
            _MailService.SendEmail(email.Reciver,email.Title,email.Message);
        }
    }
    public class RefindMailService: MailServiceAbstractions
    {

    }

    public class EmailInformationDto
    {
        public string Reciver { get; set; }=string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
    }
}
