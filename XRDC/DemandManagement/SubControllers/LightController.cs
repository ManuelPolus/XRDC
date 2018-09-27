using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XRDC.DemandManagement.SubControllers
{
    public class LightController : SubController
    {

        public override string GetError()
        {
            return "light controller error";
        }

        public override bool ExecuteRequest(string status, string options)
        {
            Console.WriteLine("LightCOntroller working. Status :" + status);
            return true;
        }
    }
}
