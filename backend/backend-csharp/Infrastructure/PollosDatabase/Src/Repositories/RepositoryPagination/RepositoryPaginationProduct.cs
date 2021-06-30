using System.Collections.Generic;
using System.Linq;
using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryPagination;
using PollosDatabase.Src.Dao.DaoPagination;
using PollosDatabase.Src.DbEntities;

namespace PollosDatabase.Src.Repositories.RepositoryPagination
{
    public class RepositoryPaginationProduct : IRepositoryPaginationProduct
    {
        public List<DomainEntityProduct> Paginate(string pageNumber, string totalPageNumber)
        {
            return DaoPaginationGeneric.Paginate<DbEntityProduct>(pageNumber, totalPageNumber)
                .Select(dbEntity => dbEntity.DbEntityToDomainEntity())
                .ToList();
        }
    }
}
