using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Sockets;
namespace httpserver
{
    class Program
    {

       
        static void Main(string[] args)
        {
            //
            //List<Task> ServerTask = new List<Task>(); 
            if (!EventLog.SourceExists(Eloging.sSoruce))
            {
                EventLog.CreateEventSource(Eloging.sSoruce, Eloging.sLog);
            }


            /// Vi laver et nyt objekt af klassen Httpserver (server)   
            HttpServer server = new HttpServer();
            /// Vi kalder metoden Startserver via vores objekt server
            
            server.StartServer();

            Console.Read();

            
        }
    }
}
