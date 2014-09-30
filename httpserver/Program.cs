using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
namespace httpserver
{
    class Program
    {

       private static HttpServer StartHosting;
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello http server");
            StartHosting = new HttpServer();
            StartHosting.StartServer();

            HttpServer server = new HttpServer();
            server.StartServer();
        }
    }
}
