using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace NetworkManager.Network
{
    public class TCPClient : IDisposable
    {

        private TcpClient _client;

        public TCPClient(bool connectAutommaticaly)
        {
            _client = new TcpClient();
            if (connectAutommaticaly)
            {
                Connect("127.0.0.1", 500);
            }
        }

        public TCPClient(string ip,int port)
        {
            Connect(ip, port);
        }

        private void Connect(string ipAddress, int port)
        {
            Console.WriteLine("Client Connecting...");
            _client.Connect(ipAddress, port);
            Console.WriteLine("Client connected...");
        }

        public void SendContent(string content)
        {
            Stream stm = _client.GetStream();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] bytes = encoding.GetBytes(content);
            Console.WriteLine("Client Transmitting data...");

            stm.Write(bytes, 0, bytes.Length);

            byte[] bytesb = new byte[300];
            int k = stm.Read(bytesb, 0, 100);

            Console.WriteLine("--Data sent !");
        }

        private void Close()
        {
            _client.Close();
        }

        public void Dispose()
        {
            Close();
            GC.SuppressFinalize(this);
        }
    }
}
