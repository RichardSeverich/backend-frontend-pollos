using PollosDatabase.Src.DbEntities;
using System.Collections.Generic;
using System.Text;

namespace PollosDatabase.Src.SqlCommands
{
    internal static class SqlCommandSelectPagination<T> where T : DbEntity
    {
        internal static List<T> Execute(string tableName,
            string pageNumber,
            string totalPageNumber)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"SELECT * FROM {tableName} ");
            query.Append($"ORDER BY(SELECT NULL) ");
            query.Append($"OFFSET {pageNumber} * {totalPageNumber} ROWS ");
            query.Append($"FETCH NEXT {totalPageNumber} ROWS ONLY;");

            return SqlCommandExecuteQueryForSelect<T>.Execute(query.ToString());
        }
    }
}
