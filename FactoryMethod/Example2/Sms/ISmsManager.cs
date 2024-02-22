using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2.Sms
{
    public interface ISmsManager
    {
        void Send(SmsDto smsDto);
        List<SmsDto> GetAll();
    }
    public class SmsDto
    {
        public string Reciver { get; set; }
        public string Sender { get; set; }
        public string Message { get; set; }
    }
}
