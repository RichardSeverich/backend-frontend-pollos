using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilter;
using System.Collections.Generic;

namespace PollosApplication.Src.UseCases.UseCaseFilter
{
    public abstract class UseCaseFilter<T> where T : DomainEntity
    {
        private IRepositoryFilter<T> _repositoryFilter;

        public UseCaseFilter(IRepositoryFilter<T> repo)
        {
            _repositoryFilter = repo;
        }

        public virtual List<T> Filter(List<string> listToFilter)
        {
            return _repositoryFilter.Filter(listToFilter);
        }
    }
}
