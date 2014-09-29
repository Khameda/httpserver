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
        
        public static readonly int DefaultPort = 8888;


        public void StartServer()
        {
            //creates a server socket/listner/welcome socket
            TcpListener serverSocket = new TcpListener(DefaultPort);
            serverSocket.Start();

            //creates a connectionSocket by accepting the connection request from the client
            Socket connectionSocket = serverSocket.AcceptSocket();
            Console.WriteLine("Server is activated");

            //network stream for the connected client; to read from or write to
            Stream ns = new NetworkStream(connectionSocket);
            StreamReader sr = new StreamReader(ns);



            StreamWriter sw = new StreamWriter(ns);
            sw.WriteLine("Hello browser!");
            sw.AutoFlush = true;

            //saves the lines read fromteh stream in a string variable and print it on the scren
            string message = sr.ReadLine();
            Console.WriteLine("write to console worked!");


            ns.Close();
            connectionSocket.Close();
            serverSocket.Stop();
        }
    }
    }

