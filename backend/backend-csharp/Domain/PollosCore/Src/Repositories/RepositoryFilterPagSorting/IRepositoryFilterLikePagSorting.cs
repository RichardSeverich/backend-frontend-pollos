using PollosCore.Src.DomainEntities;
using System.Collections.Generic;

namespace PollosCore.Src.Repositories.RepositoryFilterPagSorting
{
    public interface IRepositoryFilterLikePagSorting<T> where T : DomainEntity
    {
        public List<T> FilterSorting(string pageNumber, string totalPageNumber,
            List<string> columnsAndValues, List<string> sortingList);
    }
}
