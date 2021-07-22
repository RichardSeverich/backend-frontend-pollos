using PollosDatabase.Src.DbEntities;
using System.Collections.Generic;
using System.Text;

namespace PollosDatabase.Src.SqlCommands
{
    internal static class SqlCommandSelectFilter<T> where T : DbEntity
    {
        internal static List<T> Execute(string tableName, string columnAndValueFilter)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"SELECT * FROM {tableName} ");
            query.Append($"WHERE {columnAndValueFilter}");

            return SqlCommandExecuteQueryForSelect<T>.Execute(query.ToString());
        }
    }
}
