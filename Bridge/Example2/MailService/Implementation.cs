using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2.MailService
{
    public static class Implementation
    {
        public static IMailServiceBridge MailServiceBridge()
        {
            //string Service = "Gmail";
            //if (Service == "Gmail")
            //{
            //    return new GmailService();
            //}
            //else if (Service == "Yahoo")
            //{
            //    return new YahooService();
            //}
            //else
            //{
            //    return new MyCompanyEmailService();
            //}
            //بجای هارد کد میشه اینجوری از کانفیگ خوندش
            var config=ConfigurationManager.AppSettings;
            if (config["EmailValue"] == "Gmail")
            {
                return new GmailService();
            }
            else if (config["EmailValue"] == "Yahoo")
            {
                return new YahooService();
            }
            else
            {
                return new MyCompanyEmailService();
            }
        }
    }
}
