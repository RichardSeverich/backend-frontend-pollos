using PollosDatabase.Src.DbEntities;
using System.Collections.Generic;
using System.Text;

namespace PollosDatabase.Src.SqlCommands
{
    internal static class SqlCommandSelectPaginationAndSorting<T> where T : DbEntity
    {
        internal static List<T> Execute(string tableName,
            string pageNumber,
            string totalPageNumber,
            string sorting)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"SELECT * FROM {tableName} ");
            query.Append($"ORDER BY {sorting} ");
            query.Append($"OFFSET {pageNumber} * {totalPageNumber} ROWS ");
            query.Append($"FETCH NEXT {totalPageNumber} ROWS ONLY;");

            return SqlCommandExecuteQueryForSelect<T>.Execute(query.ToString());
        }
    }
}
