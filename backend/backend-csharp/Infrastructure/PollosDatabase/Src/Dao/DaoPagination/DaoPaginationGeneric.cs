using PollosDatabase.Src.DbEntities;
using PollosDatabase.Src.SqlCommands;
using PollosDatabase.Src.Utils;
using System.Collections.Generic;

namespace PollosDatabase.Src.Dao.DaoPagination
{
    public static class DaoPaginationGeneric
    {
        public static List<T> Paginate<T>(string pageNumber, string totalPageNumber) where T : DbEntity
        {
            var tableName = UtilAnnotationTableDb<T>.GetTableName();
            return SqlCommandSelectPagination<T>.Execute(tableName, pageNumber, totalPageNumber);
        }
    }
}
