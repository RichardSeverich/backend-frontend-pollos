using Dapper;
using PollosDatabase.Src.Connection;
using PollosDatabase.Src.DbEntities;
using System.Data.SqlClient;

namespace PollosDatabase.Src.SqlCommands
{
    internal static class SqlCommandExecuteQuery<T> where T : DbEntity
    {
        internal static void Execute(string query, T t)
        {
            using (SqlConnection dbConnection = ConnectionDb.OpenConnection())
            {
                dbConnection.Execute(query, t);
            }
        }

        internal static void Execute(string query)
        {
            using (SqlConnection dbConnection = ConnectionDb.OpenConnection())
            {
                dbConnection.Execute(query);
            }
        }
    }
}
