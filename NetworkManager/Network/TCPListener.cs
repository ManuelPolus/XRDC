using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetworkManager.Network
{
    public class TCPListener
    {

        private string _ip { get; set; }
        private IPAddress _ipAddress { get; set; }
        private int _port { get; set; }
        private bool Running { get; set; }
        private TcpListener _listener { get; set; }

        public TCPListener(string ip, int port)
        {
            _ip = ip;
            _port = port;

            Initialize();
            Run();

        }

        private void Initialize()
        {
            try
            {
                Running = true;
                _ipAddress = IPAddress.Parse(_ip);
                Console.WriteLine("Listener started...");
                _listener = new TcpListener(_ipAddress, _port);
                _listener.Start();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.StackTrace);
                Console.ReadLine();
            }
            
        }

        public string Run()
        {
            try
            {
                StringBuilder builder = new StringBuilder();

                while (Running)
                {
                    Console.WriteLine("Listener is listening on " + _listener.LocalEndpoint);

                    Console.WriteLine("Listener Waiting for a connection...");

                    Socket client = _listener.AcceptSocket();

                    Console.WriteLine("Listener accepted connection.");

                    Console.WriteLine("Listener is sReading data...");

                    byte[] data = new byte[300];
                    int size = client.Receive(data);

                    Console.WriteLine("-- data recieved !");

                    for (int i = 0; i < size; i++)
                        builder.Append(data[i]);

                    client.Close();
                }

                _listener.Stop();
                return builder.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.StackTrace);
                Console.ReadLine();
                return null;
            }

        }

        public void Stop()
        {
            Running = false;
        }




    }
}
