using PollosCore.Src.DomainEntities;
using System.Collections.Generic;

namespace PollosCore.Src.Repositories.RepositoryFilter
{
    public interface IRepositoryFilter<T> where T : DomainEntity
    {
        public List<T> Filter(List<string> columnsValuesToFilter);
    }
}
