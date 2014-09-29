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

        private static Start StartChat;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello http server");
            StartChat = new Start();
            StartChat.StartServer();
        }
    }
}
