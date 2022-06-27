using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Parser
{
    public class GetRecvest
    {
        HttpWebRequest _request;
        string _url;
        public string Response { get; set; }
        public GetRecvest(string url)
        {
            _url = url;
        }

        public void Run()
        {
            _request = (HttpWebRequest)WebRequest.Create(_url);
            _request.Method = "Get";

            try
            {
                HttpWebResponse response = (HttpWebResponse)_request.GetResponse();
                var stream = response.GetResponseStream();
                Response = new StreamReader(stream).ReadToEnd();
            }
            catch(Exception)
            {

            }

            

        }
    }
}
