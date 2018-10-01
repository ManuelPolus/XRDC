using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XRDC.DemandManagement.SubControllers
{
    /// <summary>
    ///  SubController are IoT controllers. This means each one is made to communicate through a certain protocol
    ///  and with a certain type of connected object.
    /// </summary>
    interface ISubControl
    {

        bool ExecuteRequest(string request);

        string GetError();

    }
}
