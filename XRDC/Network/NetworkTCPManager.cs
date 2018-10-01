using NetworkManager.Network;
using System;
using System.Threading.Tasks;
using XRDC.Models;
using XRDC.Network.Exceptions;

namespace XRDC.Network

{
    public class NetworkTCPManager
    {

        private TCPClient _client;
        private Request ManagerRequest { get; set; }


        public void SendRequest(string ip, int port)
        {
            using (TCPClient client = new TCPClient(ip, port))
            {
                if (ManagerRequest != null)
                    _client.SendContent(ManagerRequest.ToString());
                else
                    throw new EmptyRequestException("you must initialize the request before sending it");
            }

        }






    }
}
