using PollosDatabase.Src.DbEntities;
using System.Text;

namespace PollosDatabase.Src.SqlCommands
{
    internal static class SqlCommandInsert<T> where T : DbEntity
    {
        internal static void Execute(T t, string tableName, string columns, string values)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"INSERT INTO {tableName} ({columns}) ");
            query.Append($"VALUES({values});");
            SqlCommandExecuteQuery<T>.Execute(query.ToString(), t);
        }
    }
}
