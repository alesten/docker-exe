using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace client_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("server", 8080);
            
            NetworkStream stream = client.GetStream();

            // Receive the TcpServer.response.

            // Buffer to store the response bytes.
            Byte[] data = new Byte[256];

            // String to store the response ASCII representation.
            String responseData = String.Empty;

            // Read the first batch of the TcpServer response bytes.
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            Console.WriteLine(responseData);         

            // Close everything.
            stream.Close();         
            client.Close();     
        }
    }
}
