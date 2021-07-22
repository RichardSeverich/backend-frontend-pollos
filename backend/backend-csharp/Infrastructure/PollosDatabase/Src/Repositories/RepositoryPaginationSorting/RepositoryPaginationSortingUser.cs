using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryPaginationSorting;
using PollosDatabase.Src.Dao.DaoPaginationAndSorting;
using PollosDatabase.Src.DbEntities;
using System.Collections.Generic;
using System.Linq;

namespace PollosDatabase.Src.Repositories.RepositoryPaginationSorting
{
    public class RepositoryPaginationSortingUser : IRepositoryPaginationSortingUser
    {
        public List<DomainEntityUser> PaginateSorting(string pageNumber, string totalPageNumber,
            List<string> sortingList)
        {
            return DaoPaginationAndSortingGeneric
                .PaginateSorting<DbEntityUser>(pageNumber, totalPageNumber, sortingList)
                .Select(dbEntity => dbEntity.DbEntityToDomainEntity())
                .ToList();
        }
    }
}
