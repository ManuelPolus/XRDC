using System;
using XRDC.DemandManagement.Exceptions;
using XRDC.Utilities;

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
           throw ErrorLaucher.Launch(new ControllerMustBeSpecializedException("You must only execut request from specialized controllers instances")); 
        }

        public virtual string GetError()
        {
            throw ErrorLaucher.Launch(new ControllerMustBeSpecializedException("You must only execut request from specialized controllers instances"));
        }

        string WishedStatus { get; set; }

        string Options { get; set; }

    }
}
