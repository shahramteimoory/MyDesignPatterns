using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Decoratoe_Wrapper.UseDecratorWithOutSource
{
    public class WithOutSorceExample
    {
        public string DownloadWeb(string web)
        {
            WebClient webClient = new WebClient();
            //string sorce=  webClient.DownloadString(web);
            WebClientDecrator webClientDecrator=new WebClientDecrator(webClient);
            string sorce=webClientDecrator.DownloadString(web);
            return sorce;
        }

    }
    public class WebClientDecrator : WebClient
    {
        private readonly WebClient _webClient;
        public WebClientDecrator(WebClient webClient)
        {
            _webClient= webClient;
        }
        public string DownloadString(string address)
        {
            if (address.StartsWith("https://www.google.com/"))
            {
                return _webClient.DownloadString(address);
            }
            else
            {
                return string.Empty;
            }
          
        }
    }
}
