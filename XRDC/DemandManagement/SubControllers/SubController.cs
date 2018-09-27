using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XRDC.DemandManagement.Exceptions;

namespace XRDC.DemandManagement.SubControllers
{
    public abstract class SubController
    {

        public static Object Build(object controllerObject)
        {
            return controllerObject is SubController ? controllerObject : null;
        }

        public virtual bool ExecuteRequest(string status, string options)
        {
            throw new ControllerMustBeSpecializedException("You must only execut request from specialized controllers instances");
        }

        public virtual string GetError()
        {
            throw new ControllerMustBeSpecializedException();
        }

        string WishedStatus { get; set; }

        string Options { get; set; }

    }
}
