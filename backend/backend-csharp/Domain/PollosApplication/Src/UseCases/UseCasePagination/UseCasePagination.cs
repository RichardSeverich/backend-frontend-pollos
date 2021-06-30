using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryPagination;
using System.Collections.Generic;

namespace PollosApplication.Src.UseCases.UseCasePagination
{
    public abstract class UseCasePagination<T> where T : DomainEntity
    {
        protected IRepositoryPagination<T> _repoGeneric;

        public UseCasePagination(IRepositoryPagination<T> repoGeneric)
        {
            _repoGeneric = repoGeneric;
        }

        public virtual List<T> Paginate(string pageNumber, string totalPageNumber)
        {
            return _repoGeneric.Paginate(pageNumber, totalPageNumber);
        }
    }
}
