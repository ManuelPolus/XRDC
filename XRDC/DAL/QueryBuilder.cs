using System;
using System.Text;
using XRDC.DAL.RequestExceptions;

namespace XRDC.DAL
{
    public static class QueryBuilder
    {
        public static string SELECT(string arguments, string tableName)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("SELECT" + arguments);
            builder.Append("FROM" + tableName);

            return builder.ToString();
        }

        public static string SELECT(string arguments, string tableName, string filter)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("SELECT" + arguments);
            builder.Append("FROM" + tableName);
            builder.Append("WHERE" + filter);

            return builder.ToString();
        }

        public static bool INSERT(string tableName, string arguments, string values)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(" INSERT INTO TABLE " + tableName);
            builder.Append(" ( " + arguments + " ) ");
            builder.Append(" VALUES (" + values + ")");

            return false;
        }

        public static void UPDATE(string tableName, string[] arguments, string[] values)
        {
            StringBuilder builder = new StringBuilder();

            if (arguments.Length != values.Length)
            {
                throw new SQLRequestArgumentsException("arguments must all have a value and the other way around");
            }

            builder.Append(" UPDATE TABLE " + tableName);
            builder.Append("SET ");
            for (int i = 0; i < arguments.Length; i++)
            {
                builder.Append(arguments[i] + " = " + values[i]);
                if (i < arguments.Length - 1)
                {
                    builder.Append(",");
                }
            }

            builder.Append(";");
        }

        public static void DELETE()
        {
            throw new NotImplementedException();
        }

    }
}
