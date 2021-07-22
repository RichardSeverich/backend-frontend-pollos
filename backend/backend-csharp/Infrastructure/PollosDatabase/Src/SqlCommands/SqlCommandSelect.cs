using PollosDatabase.Src.DbEntities;
using System.Collections.Generic;
using System.Text;

namespace PollosDatabase.Src.SqlCommands
{
    internal static class SqlCommandSelect<T> where T : DbEntity
    {
        internal static List<T> Execute(string tableName)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"SELECT * FROM {tableName}");

            return SqlCommandExecuteQueryForSelect<T>.Execute(query.ToString());
        }
    }
}
