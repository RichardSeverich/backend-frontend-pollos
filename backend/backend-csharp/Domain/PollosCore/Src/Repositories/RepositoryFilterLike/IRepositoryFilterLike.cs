using PollosCore.Src.DomainEntities;
using System.Collections.Generic;

namespace PollosCore.Src.Repositories.RepositoryFilterLike
{
    public interface IRepositoryFilterLike<T> where T : DomainEntity
    {
        public List<T> FilterLike(List<string> listToFilter);
    }
}
