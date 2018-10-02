using System;
using XRDC.DAL.SelfMadeORMAttempt;
using XRDC.DAL.SelfMadeORMAttempt.Exceptions;

namespace XRDC.DAL
{
    /// <summary>
    /// You must only use this class to initialize specialized managers. The managers musto only be used into using(){} clauses.
    /// The managers take db connection opening and closing in  charge.
    /// </summary>
    public abstract class DbManager : IDisposable, IManageDb
    {

        public DbManager()
        {
        }

        /// <summary>
        /// You must not use this function as it will throw an error. Instead,specify a specialized manager type
        /// and it's constructor will automaticly open connection.
        /// </summary>
        public virtual void OpenConnection()
        {
           throw new NoConcreteDatabaseManagerException();
        }

        /// <summary>
        /// You must not use this function as it will throw an error. Instead,specify a specialized manager type
        /// and it's constructor will automaticly open connection.
        /// </summary>
        public virtual void CloseConnection()
        {
            throw new NoConcreteDatabaseManagerException();
        }

        public virtual void Dispose()
        {
            CloseConnection();
            GC.SuppressFinalize(this);
        }

    }
}
