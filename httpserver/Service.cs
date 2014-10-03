using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace httpserver
{
    internal class Service
    {

        /// Vi declare vores RootCatalog med placering "c:/temp"  
        /// Tanken er hvis vi har brug for flere filer opretter vi en seperat klasse dedikeret til filer eks. Filkatalog
        private static readonly string RootCatalog = "c:/temp";

        private TcpClient connectionSocket;

        public Service(TcpClient connectionSocket)
        {
            this.connectionSocket = connectionSocket;  
        }

       //public List<Task> ServerTasks = new List<Task>();

 
        

        public void SocketService()
        {

            //Task task = Task.Run(() => (connectionSocket));
         //   Task.Run(task);
            /// Netværks stream for vores connectede client som kan bruges til at læse eller skrive til eller fra
            Stream ns = connectionSocket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true;

            sw.Write("HTTP/1.0 200 OK\r\n");
            /// "Blank lines"
            sw.Write("\r\n");
            /// "Entity body"
            sw.Write("Hello world");
            /// Her kalder vi vores metode SendREfile ved brug af Stream streamReader StreamWriter           
            string m = sr.ReadLine();
            string filename = GetREfilePath(m);

            SendREFile(filename, sw);

      

     
           
            /// Vi lukker vores stream    
            ns.Close();
            /// vi lukker client connection
            connectionSocket.Close();
            
        }


     

        private string GetREfilePath(string message)
        {
            //Task task = Task.Run(() => (connectionSocket));               
            if (true)
            {                          
                string[] adskil = message.Split(' ');                
                return RootCatalog + adskil[1];
            }
        
            // task.Start();

        }

        /// message det vi skriver i browseren i dette tilfælde localhost:8888/arg --> sr.Readline læser alle request.
        ///adskil opdeler message ved hjælp af indbygget Split metode.
        /// sw.writeline udskriver element '1'  i browseren i dette tilfælde /arg
        /// element 1 hedder Entity body
        
        private void SendREFile(string filename, StreamWriter sw)
        {
            try
            {

                string bla = filename;

                if (File.Exists(filename))
                {
                    using (FileStream fs = File.OpenRead(filename))
                    {


                        byte[] b = new byte[1024];
                        UTF8Encoding temp = new UTF8Encoding(true);
                        while (fs.Read(b, 0, b.Length) > 0)
                        {
                            sw.WriteLine(temp.GetString(b));
                        }
                    }
                }
            }
            catch
                (Exception BadMessage)
            {
                Console.WriteLine(BadMessage);
            }
        }
        
    }
}