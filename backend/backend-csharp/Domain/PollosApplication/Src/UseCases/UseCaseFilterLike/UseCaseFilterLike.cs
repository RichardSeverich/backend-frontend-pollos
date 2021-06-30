using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilterLike;
using System.Collections.Generic;

namespace PollosApplication.Src.UseCases.UseCaseFilterLike
{
    public abstract class UseCaseFilterLike<T> where T : DomainEntity
    {
        IRepositoryFilterLike<T> _repository;
        public UseCaseFilterLike(IRepositoryFilterLike<T> repo)
        {
            _repository = repo;
        }

        public virtual List<T> FilterLike(List<string> listToFilter)
        {
            return _repository.FilterLike(listToFilter);
        }
    }
}
