using PollosDatabase.Src.DbEntities;
using System.Text;

namespace PollosDatabase.Src.SqlCommands
{
    internal static class SqlCommandDelete<T> where T : DbEntity
    {
        internal static void Execute(string tableName, int id)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"DELETE FROM {tableName} ");
            query.Append($"WHERE id = {id}");
            SqlCommandExecuteQuery<T>.Execute(query.ToString());
        }
    }
}
