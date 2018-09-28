using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XRDC.DAL.RequestExceptions
{
    public class SQLRequestArgumentsException : Exception
    {

        public SQLRequestArgumentsException()
        {

        }

        public SQLRequestArgumentsException(string message) : base(message)
        {

        }

        public SQLRequestArgumentsException(string message, Exception inner) : base(message, inner)
        {

        }

    }
}
