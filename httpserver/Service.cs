using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace httpserver
{
    internal class Service
    {
        private TcpClient connectionSocket;

        public Service(TcpClient connectionSocket)
        {
            this.connectionSocket = connectionSocket;
        }

        public void SocketService()
        {

            //network stream for the connected client; to read from or write to
            Stream ns = connectionSocket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true;

            sw.WriteLine("Hello browser!");
            sw.WriteLine("Hello many times");
            sw.WriteLine(
                "<HTML><HEAD><TITLE>My Home Page</TITLE></HEAD><BODY><H1>My Home Page</H1>Hi There!</BODY></HTML>");



            // message det vi skriver i browseren i dette tilfælde localhost:8888/arg --> sr.Readline læser alle request.
            string message = sr.ReadLine();
            //adskil opdeler message ved hjælp af indbygget Split metode.
            string[] adskil = message.Split(' ');
            // sw.writeline udskriver element '1'  i browseren i dette tilfælde /arg
            sw.WriteLine(adskil[1]);





            ns.Close();
            connectionSocket.Close();
        }
    }
}