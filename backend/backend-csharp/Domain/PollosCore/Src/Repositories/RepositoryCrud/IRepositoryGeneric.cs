using PollosCore.Src.DomainEntities;
using System.Collections.Generic;

namespace PollosCore.Src.Repositories.RepositoryCrud
{
    public interface IRepositoryGeneric<T> where T : DomainEntity
    {
        public void Create(T t);
        public List<T> Read();
        public void Update(int id, T t);
        public void Delete(int id);
    }
}
