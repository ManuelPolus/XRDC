using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XRDC.Network.Exceptions
{
    public class EmptyRequestException : Exception
    {

        public EmptyRequestException()
        {

        }

        public EmptyRequestException(string message) : base(message)
        {

        }

        public EmptyRequestException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
