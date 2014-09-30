﻿using System;
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
       

       // vi laver en statisk port og navngiver den DefaultPort
       public static readonly int DefaultPort = 8888;


       public void StartServer()
       {
           //creates a server socket/listner/welcome socket
           TcpListener serverSocket = new TcpListener(DefaultPort);
           serverSocket.Start();

           //creates a connectionSocket by accepting the connection request from the client
           TcpClient connectionSocket = serverSocket.AcceptTcpClient();
           Console.Write("Server is activated");

           Service ser = new Service(connectionSocket);
           ser.SocketService();
           serverSocket.Stop();
        }
    }
    }

