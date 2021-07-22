using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryCrud;
using System.Collections.Generic;

namespace PollosApplication.Src.UseCases.UseCaseCrud
{
    public abstract class UseCaseCrud<T> where T : DomainEntity
    {
        protected IRepositoryGeneric<T> _repoGeneric;

        public UseCaseCrud(IRepositoryGeneric<T> reposGeneric)
        {
            _repoGeneric = reposGeneric;
        }

        public virtual void Create(T t)
        {
            _repoGeneric.Create(t);
        }

        public virtual List<T> Read()
        {
            return _repoGeneric.Read();
        }

        public virtual void Update(int id, T t)
        {
            _repoGeneric.Update(id, t);
        }

        public virtual void Delete(int id)
        {
            _repoGeneric.Delete(id);
        }
    }
}
