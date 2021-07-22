using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryCrud;
using PollosDatabase.Src.Dao.DaoCrud;
using PollosDatabase.Src.DbEntities;
using System.Collections.Generic;
using System.Linq;

namespace PollosDatabase.Src.Repositories.RepositoryCrud
{
    public class RepositoryUser : IRepositoryUser
    {
        public void Create(DomainEntityUser domainEntity)
        {
            DbEntityUser dbEntity = DbEntityUser.DomainEntityToDbEntity(domainEntity);
            DaoUser.Create(dbEntity);
        }

        public List<DomainEntityUser> Read()
        {
            return DaoUser.Read().Select(dbEntity => dbEntity.DbEntityToDomainEntity()).ToList();
        }

        public void Update(int id, DomainEntityUser domainEntity)
        {
            DbEntityUser dbEntity = DbEntityUser.DomainEntityToDbEntity(domainEntity);
            DaoUser.Update(id, dbEntity);
        }

        public void Delete(int id)
        {
            DaoUser.Delete(id);
        }
    }
}
