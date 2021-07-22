using Dapper;
using PollosDatabase.Src.Connection;
using PollosDatabase.Src.DbEntities;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace PollosDatabase.Src.SqlCommands
{
    internal static class SqlCommandExecuteQueryForSelect<T> where T : DbEntity
    {
        internal static List<T> Execute(string query)
        {
            using (SqlConnection connection = ConnectionDb.OpenConnection())
            {
                return connection.Query<T>(query).ToList();
            }
        }
    }
}
