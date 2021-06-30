using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilterPagSorting;
using PollosDatabase.Src.Dao.DaoFilter;
using PollosDatabase.Src.DbEntities;
using System.Collections.Generic;
using System.Linq;

namespace PollosDatabase.Src.Repositories.RepositoryFilterLikePagSorting
{
    public class RepositoryFilterLikePagSortingClient : IRepositoryFilterLikePagSortingClient
    {
        public List<DomainEntityClient> FilterSorting(string pageNumber, string totalPageNumber, List<string> columnsAndValues, List<string> sortingList)
        {
            var dbList = DaoFilterPagSortingGeneric.Filter<DbEntityClient>(pageNumber, totalPageNumber,
                columnsAndValues, sortingList);

            return dbList.Select(dbEntity => dbEntity.DbEntityToDomainEntity()).ToList();
        }
    }
}
