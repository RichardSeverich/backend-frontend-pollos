using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilterPagSorting;
using System.Collections.Generic;

namespace PollosApplication.Src.UseCases.UseCaseFilterSorting
{
    public abstract class UseCaseFilterLikePagSorting<T> where T : DomainEntity
    {
        IRepositoryFilterLikePagSorting<T> _repository;
        public UseCaseFilterLikePagSorting(IRepositoryFilterLikePagSorting<T> repo)
        {
            _repository = repo;
        }

        public virtual List<T> FilterSorting(string pageNumber, string totalPageNumber, 
            List<string> columnsAndValues, List<string> sortingList)
        {
            return _repository.FilterSorting(pageNumber, totalPageNumber, columnsAndValues, sortingList);
        }
    }
}
