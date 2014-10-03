using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace httpserver
{
    public class HttpServer
    {
        /// vi laver en statisk port og navngiver den DefaultPort
        public static readonly int DefaultPort = 8888;

        

        private bool _running;
        
        public void StartServer()
        {
            _running = true;

            

            /// Vi laver en server listner og kalder den serverSocket
            TcpListener serverSocket = new TcpListener(DefaultPort);
            /// Vi åbner forbindelsen
            serverSocket.Start();

            Eloging.Ewriting("Server started succesfully", "Information");
         
            List<Task> Liste = new List<Task>();
            while (_running)
            {
                
                //
                /// vi laver en tcpclient objekt og fortæller at vores listner at den skal acceptere forbindelsen
                TcpClient connectionSocket = serverSocket.AcceptTcpClient();
                /// Den giver sig selv
                Console.Write("Server is activated");
                /// vi laver et objekt af vores klasse service og kalder metoden Socketservice
              
                ///Vi lukker forbindelen
                Liste.Add(Task.Run(() =>
                {
                    Service ser = new Service(connectionSocket);
                    ser.SocketService(connectionSocket);                
                }));
                
                
            }
            serverSocket.Stop();
        }
        
    }
    }

