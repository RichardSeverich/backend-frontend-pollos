using PollosDatabase.Src.DbEntities;
using PollosDatabase.Src.SqlCommands;
using PollosDatabase.Src.Utils;
using System.Collections.Generic;

namespace PollosDatabase.Src.Dao.DaoFilter
{
    public static class DaoFilterGeneric
    {
        public static List<T> Filter<T>(List<string> filterList) where T : DbEntity
        {
            var tableName = UtilAnnotationTableDb<T>.GetTableName();
            string queryFilter = FilterBuilder.Build(filterList, "=", "=");

            return SqlCommandSelectFilter<T>.Execute(tableName, queryFilter);
        }
    }
}
