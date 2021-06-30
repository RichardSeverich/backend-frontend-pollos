using PollosDatabase.Src.DbEntities;
using System.Text;

namespace PollosDatabase.Src.SqlCommands
{
    internal static class SqlCommandUpdate<T> where T : DbEntity
    {
        internal static void Execute(T t, string tableName, int id, string columnsAndValues)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"UPDATE {tableName} ");
            query.Append($"SET {columnsAndValues} ");
            query.Append($"WHERE id={id};");
            SqlCommandExecuteQuery<T>.Execute(query.ToString(), t);
        }
    }
}
