using System.Collections.Generic;
using System.Linq;
using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryPagination;
using PollosDatabase.Src.Dao.DaoPagination;
using PollosDatabase.Src.DbEntities;

namespace PollosDatabase.Src.Repositories.RepositoryPagination
{
    public class RepositoryPaginationUser : IRepositoryPaginationUser
    {
        public List<DomainEntityUser> Paginate(string pageNumber, string totalPageNumber)
        {
            return DaoPaginationGeneric.Paginate<DbEntityUser>(pageNumber, totalPageNumber)
                .Select(dbEntity => dbEntity.DbEntityToDomainEntity())
                .ToList();
        }
    }
}
