using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryPaginationSorting;
using System.Collections.Generic;

namespace PollosApplication.Src.UseCases.UseCasePaginationSorting
{
    public class UseCasePaginationSorting<T> where T : DomainEntity
    {
        protected IRepositoryPaginationSorting<T> _repoGeneric;

        public UseCasePaginationSorting(IRepositoryPaginationSorting<T> repoGeneric)
        {
            _repoGeneric = repoGeneric;
        }

        public virtual List<T> PaginateSorting(string pageNumber,string totalPageNumber,
            List<string> sortingList)
        {
            return _repoGeneric.PaginateSorting(pageNumber, totalPageNumber, sortingList);
        }
    }
}
