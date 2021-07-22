using System.Collections.Generic;
using System.Text;

namespace PollosDatabase.Src.Dao.DaoFilter
{
    internal static class FilterLikeBuilder
    {
        internal static string Build(List<string> filterList, string splitBy, string compareBy)
        {
            StringBuilder queryFilter = new StringBuilder();
            filterList.ForEach(filter => 
            {
                var array = filter.Split(splitBy);
                array[1] = $"'%{array[1]}%'";
                queryFilter.Append(array[0] + compareBy + array[1] + " AND ");
            });
            queryFilter.Remove(queryFilter.Length - 4, 4);

            return queryFilter.ToString();
        }
    }
}
