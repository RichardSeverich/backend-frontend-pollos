using PollosDatabase.Src.DbEntities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace PollosDatabase.Src.Utils
{
    internal static class UtilAnnotationTableDb<T> where T : DbEntity
    {
        internal static string GetTableName()
        {
            var dnAttribute = typeof(T).GetCustomAttributes(typeof(TableAttribute), true)
                .FirstOrDefault() as TableAttribute;

            if (dnAttribute != null)
            {
                return dnAttribute.Name;
            }

            return null;
        }
    }
}
