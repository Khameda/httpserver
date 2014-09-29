using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

//namespace httpserver
//{
//    class Start
//    {
//        public void StartServer()
//        {
//            //creates a server socket/listner/welcome socket
//            TcpListener serverSocket = new TcpListener(8888);
//            serverSocket.Start();

//            //creates a connectionSocket by accepting the connection request from the client
//            Socket connectionSocket = serverSocket.AcceptSocket();
//            Console.WriteLine("Connection established");
//            Service service = new Service(connectionSocket);

//            //network stream for the connected client; to read from or write to
//            Stream ns = new NetworkStream(connectionSocket);
//            StreamReader sr = new StreamReader(ns);

//            StreamWriter sw = new StreamWriter(ns);
//            sw.WriteLine("Hello browser");
//            sw.AutoFlush = true;
            
//            ns.Close();
//            connectionSocket.Close();
//            serverSocket.Stop();
//            service.SocketHandler();

//        }
//    }
//}
