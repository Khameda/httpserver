using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace httpserver
{
    class Start
    {
        public void StartServer()
        {
            //creates a server socket/listner/welcome socket
            TcpListener serverSocket = new TcpListener(8888);
            serverSocket.Start();

            //creates a connectionSocket by accepting the connection request from the client
            Socket connectionSocket = serverSocket.AcceptSocket();
            Service service = new Service(connectionSocket);

            service.SocketHandler();

        }
    }
}
