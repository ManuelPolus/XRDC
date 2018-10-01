using System;
using System.Diagnostics;
using XRDC.Network;
using XRDC.Network.Exceptions;

namespace XRDC.DemandManagement.SubControllers
{
    public class MusicController : SubController
    {

        public override bool ExecuteRequest(string status, string options)
        {
            try
            {
                NetworkTCPManager manager = new NetworkTCPManager();

                manager.SendRequest("127.0.0.1", 502);

                return true;
            }
            catch (EmptyRequestException e)
            {
                Debug.WriteLine(e.StackTrace);
                return false;
            }
            catch (Exception e)
            {

                Debug.WriteLine(e.StackTrace);
                return false;
            }
        }

        public override string GetError()
        {
            return "music controller error";
        }

    }
}
