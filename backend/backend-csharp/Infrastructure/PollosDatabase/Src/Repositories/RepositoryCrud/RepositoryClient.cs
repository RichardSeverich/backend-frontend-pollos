using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryCrud;
using PollosDatabase.Src.Dao.DaoCrud;
using PollosDatabase.Src.DbEntities;
using System.Collections.Generic;
using System.Linq;

namespace PollosDatabase.Src.Repositories.RepositoryCrud
{
    public class RepositoryClient : IRepositoryClient
    {
        public void Create(DomainEntityClient domainEntity)
        {
            DbEntityClient dbEntity = DbEntityClient.DomainEntityToDbEntity(domainEntity);
            DaoClient.Create(dbEntity);
        }
        public List<DomainEntityClient> Read()
        {
            return DaoClient.Read().Select(dbEntity => dbEntity.DbEntityToDomainEntity()).ToList();
        }

        public void Update(int id, DomainEntityClient domainEntity)
        {
            DbEntityClient dbEntity = DbEntityClient.DomainEntityToDbEntity(domainEntity);
            DaoClient.Update(id, dbEntity);
        }

        public void Delete(int id)
        {
            DaoClient.Delete(id);
        }
    }
}
