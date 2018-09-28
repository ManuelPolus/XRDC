using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XRDC.DemandManagement.Exceptions
{
    public class ControllerMustBeSpecializedException : Exception
    {
        public ControllerMustBeSpecializedException()
        {
        }

        public ControllerMustBeSpecializedException(string message) : base(message)
        {
           
        }

        public ControllerMustBeSpecializedException(string message,Exception inner) : base(message, inner)
        {
      
        }  

    }
}
