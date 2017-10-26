using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace server_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;

            TcpListener myListner = 
                new TcpListener(IPAddress.Any, 8080);
            myListner.Start();

            while(!quit)
            {
                Socket mySocket = myListner.AcceptSocket();
                Stream myStream = new NetworkStream(mySocket);
                StreamWriter writer = new StreamWriter(myStream)
                    {
                        AutoFlush = true
                    };
                writer.WriteLine("Hello I'm a TCP server");
                myStream.Close();
                mySocket.Close();
            }
        }
    }
}
