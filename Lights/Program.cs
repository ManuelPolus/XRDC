using NetworkManager.Network;
using System;
using System.Threading.Tasks;

namespace Lights
{
    class Program
    {
        private static TCPListener listener;

        static void Main(string[] args)
        {
            Task.Run(async () => await RunListenerAsync());
            TCPClient c = new TCPClient(true);
            c.SendContent("{bonjour, comment allez vous ?}");
            string str = "abcd";
            string str2 = "efgh";

            Console.ReadLine();
        }

        private static async Task RunListenerAsync()
        {
            listener = new TCPListener("127.0.0.1",500);
            listener.Run();
        }
    }
}
