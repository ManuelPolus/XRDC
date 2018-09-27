using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XRDC.DemandManagement.SubControllers
{
    interface ISubControl
    {

        bool ExecuteRequest(string request);

        string GetError();

    }
}
