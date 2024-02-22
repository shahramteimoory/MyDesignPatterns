﻿using FactoryMethod.Example2.Sms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2.Twilio
{
    public class TwilioSmsManager : ISmsManager
    {
        public List<SmsDto> GetAll()
        {
            List<SmsDto> smsDtos = new List<SmsDto>();
            return smsDtos;
        }

        public void Send(SmsDto smsDto)
        {
            Console.WriteLine("Twilio Sms Sended");
        }
    }
}
