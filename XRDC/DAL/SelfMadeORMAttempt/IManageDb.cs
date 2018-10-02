namespace XRDC.DAL.SelfMadeORMAttempt
{
    interface IManageDb
    {
        void OpenConnection();

        void CloseConnection();
    }
}
