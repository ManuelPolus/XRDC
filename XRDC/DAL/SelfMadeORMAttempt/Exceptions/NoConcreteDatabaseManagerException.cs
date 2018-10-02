using System;

namespace XRDC.DAL.SelfMadeORMAttempt.Exceptions
{
    public class NoConcreteDatabaseManagerException : Exception
    {
        public NoConcreteDatabaseManagerException()
        {

        }

        public NoConcreteDatabaseManagerException(string message) : base(message)
        {

        }

        public NoConcreteDatabaseManagerException(string message, Exception inner) : base(message, inner)
        {

        }

    }
}
