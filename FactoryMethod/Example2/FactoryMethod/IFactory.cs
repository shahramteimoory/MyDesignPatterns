using FactoryMethod.Example2.KavehNegar;
using FactoryMethod.Example2.Sms;
using FactoryMethod.Example2.Twilio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2.FactoryMethod
{
    public interface IFactory
    {
        ISmsManager FactoryMethod();
    }
    public class Factory2 : IFactory
    {
        public ISmsManager FactoryMethod()
        {
            string config = "KavehNegar";
            if (config == "KavehNegar")
            {
                return new KavehNegarSmsManager();
            }else
            {
                return new TwilioSmsManager();
            }
        }
    }
}
