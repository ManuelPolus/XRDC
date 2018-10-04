using System;
using XRDC.Network;
using XRDC.Network.Exceptions;
using XRDC.Utilities;

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
                ErrorLaucher.Display(e);
                return false;
            }
            catch (Exception e)
            {

                ErrorLaucher.Display(e);
                return false;
            }
        }

        public override string GetError()
        {
            return "music controller error";
        }

    }
}
