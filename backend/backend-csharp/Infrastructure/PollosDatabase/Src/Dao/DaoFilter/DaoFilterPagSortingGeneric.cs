using PollosDatabase.Src.DbEntities;
using PollosDatabase.Src.SqlCommands;
using PollosDatabase.Src.Utils;
using System.Collections.Generic;

namespace PollosDatabase.Src.Dao.DaoFilter
{
    public static class DaoFilterPagSortingGeneric
    {
        public static List<T> Filter<T>(string pageNumber, string totalPageNumber, 
            List<string> columnsAndValues, List<string> sortingList) where T : DbEntity
        {
            var tableName = UtilAnnotationTableDb<T>.GetTableName();
            string queryFilter = FilterLikeBuilder.Build(columnsAndValues, "=", " LIKE ");

            string sorting = sortingList != null && sortingList.Count > 0
                ? string.Join(",", sortingList.ToArray())
                : "(SELECT NULL)";

            return SqlCommandSelectPaginationSortingFilter<T>.Execute(tableName, pageNumber, 
                totalPageNumber, sorting, queryFilter);
        }
    }
}
