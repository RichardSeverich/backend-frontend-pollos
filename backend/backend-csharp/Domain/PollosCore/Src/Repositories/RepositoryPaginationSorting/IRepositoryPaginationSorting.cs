using PollosCore.Src.DomainEntities;
using System.Collections.Generic;

namespace PollosCore.Src.Repositories.RepositoryPaginationSorting
{
    public interface IRepositoryPaginationSorting<T> where T : DomainEntity
    {
        public List<T> PaginateSorting(string pageNumber,
            string totalPageNumber, List<string> sortingList);
    }
}
