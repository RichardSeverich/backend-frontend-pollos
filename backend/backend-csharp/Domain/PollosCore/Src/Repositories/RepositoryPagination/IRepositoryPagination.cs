using PollosCore.Src.DomainEntities;
using System.Collections.Generic;

namespace PollosCore.Src.Repositories.RepositoryPagination
{
    public interface IRepositoryPagination<T> where T : DomainEntity
    {
        public List<T> Paginate(string pageNumber, string totalPageNumber);
    }
}
