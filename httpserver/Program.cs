﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
namespace httpserver
{
    class Program
    {

       
        static void Main(string[] args)
        {
            // Vi laver et nyt objekt af klassen Httpserver (server)   
            HttpServer StartHosting = new HttpServer();
            // Vi kalder metoden Startserver via vores objekt server
            StartHosting.StartServer();

            Console.Read();
        }
    }
}
