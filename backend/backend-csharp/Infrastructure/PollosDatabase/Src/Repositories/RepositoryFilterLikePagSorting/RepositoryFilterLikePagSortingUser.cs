using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilterPagSorting;
using PollosDatabase.Src.Dao.DaoFilter;
using PollosDatabase.Src.DbEntities;
using System.Collections.Generic;
using System.Linq;

namespace PollosDatabase.Src.Repositories.RepositoryFilterLikePagSorting
{
    public class RepositoryFilterLikePagSortingUser : IRepositoryFilterLikePagSortingUser
    {
        public List<DomainEntityUser> FilterSorting(string pageNumber, string totalPageNumber,
            List<string> columnsAndValues, List<string> sortingList)
        {
            var dbList = DaoFilterPagSortingGeneric.Filter<DbEntityUser>(pageNumber, totalPageNumber,
                columnsAndValues, sortingList);

            return dbList.Select(dbEntity => dbEntity.DbEntityToDomainEntity()).ToList();
        }
    }
}
