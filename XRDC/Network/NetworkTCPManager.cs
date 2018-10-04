using NetworkManager.Network;
using System;
using System.Threading.Tasks;
using XRDC.Models;
using XRDC.Network.Exceptions;
using XRDC.Utilities;

namespace XRDC.Network

{
    public class NetworkTCPManager
    {

        private TCPClient _client;
        private Request ManagerRequest { get; set; }


        public void SendRequest(string ip, int port)
        {
            using (_client = new TCPClient(ip, port))
            {
                if (ManagerRequest != null)
                    _client.SendContent(ManagerRequest.ToString());
                else
                    throw ErrorLaucher.Launch(new EmptyRequestException("you must initialize the request before sending it"));
            }
        }

    }
}
