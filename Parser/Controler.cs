using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    internal class Controler
    {
        static string url = "https://1k.by/";
        static void Main(string[] args)
        {

            var request = new GetRecvest(url);
            request.Run();
            Print(url,request.Response);
        }
        static void Print(string path, string result)
        {
            path = path.Split(new char[] { '/' })[2]+".json";
            StreamWriter writer = new StreamWriter(path, false);
            writer.WriteLine(result);
            writer.Close();
        }
    }
}
