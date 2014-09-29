using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace httpserver
{
    class Service
    {
        private Socket connectionSocket;
        public Service(Socket connectionSocket)
        {
            this.connectionSocket = connectionSocket;
        }

        internal void SocketHandler()
        {
            Stream ns = new NetworkStream(connectionSocket);
            StreamReader sr = new StreamReader(ns);

            //saves the lines read fromteh stream in a string variable and print it on the scren
            string message = sr.ReadLine();
            //Console.WriteLine(message);
            while (message != null && message != "")
            {
                Console.WriteLine(message);
                message = sr.ReadLine();
            }
            Console.ReadLine();     
            
            connectionSocket.Close();
            


        }
    }
}
