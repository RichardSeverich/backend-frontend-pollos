using PollosDatabase.Src.DbEntities;
using PollosDatabase.Src.SqlCommands;
using PollosDatabase.Src.Utils;
using System.Collections.Generic;

namespace PollosDatabase.Src.Dao.DaoPaginationAndSorting
{
    public static class DaoPaginationAndSortingGeneric
    {
        public static List<T> PaginateSorting<T>(string pageNumber, string totalPageNumber,
            List<string> sortingList) where T : DbEntity
        {
            var tableName = UtilAnnotationTableDb<T>.GetTableName();

            string sorting = sortingList != null && sortingList.Count > 0
                ? string.Join(",", sortingList.ToArray())
                : "(SELECT NULL)";

            return SqlCommandSelectPaginationAndSorting<T>
                .Execute(tableName, pageNumber, totalPageNumber, sorting);
        }
    }
}
