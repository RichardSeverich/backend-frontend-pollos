using PollosDatabase.Src.DbEntities;
using PollosDatabase.Src.SqlCommands;
using System.Collections.Generic;

namespace PollosDatabase.Src.Dao.DaoPaginationAndSorting
{
    public static class DaoPaginationAndSortingUser
    {
        public static List<DbEntityUser> PaginateSorting(string pageNumber, string totalPageNumber,
            List<string> sortingList)
        {
            string sorting = sortingList != null && sortingList.Count > 0
                ? string.Join(",", sortingList.ToArray())
                : "(SELECT NULL)";

            return SqlCommandSelectPaginationAndSorting<DbEntityUser>
                .Execute("users", pageNumber, totalPageNumber, sorting);
        }
    }
}
