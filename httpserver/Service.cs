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
        private TcpClient connectionSocket;
        public Service(TcpClient connectionSocket)
        {
            this.connectionSocket = connectionSocket;
        }
        

       public void SocketHandler()
        {
            Stream ns = connectionSocket.GetStream();
          //  StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true;
           
            sw.Write("<html><body>Hello Chrome</body></html>");
            //sw.WriteLine("Printing many lines");
            connectionSocket.Close();

        }
    }
}
