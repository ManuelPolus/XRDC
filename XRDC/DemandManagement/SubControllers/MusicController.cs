using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace XRDC.DemandManagement.SubControllers
{
    public class MusicController : SubController
    {

        public override bool ExecuteRequest(string status, string options)
        {
            Debug.WriteLine("status: " + status);
            Debug.WriteLine("music to play : " + options );
            return true;
        }

        public override string GetError()
        {
            return "music controller error";
        }

    }
}
