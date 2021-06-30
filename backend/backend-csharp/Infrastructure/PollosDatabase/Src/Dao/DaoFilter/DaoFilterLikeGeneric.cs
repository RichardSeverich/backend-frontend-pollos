using PollosDatabase.Src.DbEntities;
using PollosDatabase.Src.SqlCommands;
using PollosDatabase.Src.Utils;
using System.Collections.Generic;

namespace PollosDatabase.Src.Dao.DaoFilter
{
    public static class DaoFilterLikeGeneric
    {
        public static List<T> Filter<T>(List<string> columnsAndValues) where T : DbEntity
        {
            var tableName = UtilAnnotationTableDb<T>.GetTableName();
            string queryFilter = FilterLikeBuilder.Build(columnsAndValues, "=", " LIKE ");

            return SqlCommandSelectFilter<T>.Execute(tableName, queryFilter);
        }
    }
}
