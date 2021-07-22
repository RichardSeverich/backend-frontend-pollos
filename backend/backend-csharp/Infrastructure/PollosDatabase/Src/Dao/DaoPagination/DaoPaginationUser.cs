using PollosDatabase.Src.DbEntities;
using PollosDatabase.Src.SqlCommands;
using System.Collections.Generic;

namespace PollosDatabase.Src.Dao.DaoPagination
{
    public static class DaoPaginationUser
    {
        public static List<DbEntityUser> Paginate(string pageNumber, string totalPageNumber)
        {
            return SqlCommandSelectPagination<DbEntityUser>.Execute("users", pageNumber, totalPageNumber);
        }
    }
}
