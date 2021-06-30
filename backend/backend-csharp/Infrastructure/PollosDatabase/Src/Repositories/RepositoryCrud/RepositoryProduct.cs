using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryCrud;
using PollosDatabase.Src.Dao.DaoCrud;
using PollosDatabase.Src.DbEntities;
using System.Collections.Generic;
using System.Linq;

namespace PollosDatabase.Src.Repositories.RepositoryCrud
{
    public class RepositoryProduct : IRepositoryProduct
    {
        public void Create(DomainEntityProduct domainEntity)
        {
            DbEntityProduct dbEntity = DbEntityProduct.DomainEntityToDbEntity(domainEntity);
            DaoProduct.Create(dbEntity);
        }

        public List<DomainEntityProduct> Read()
        {
            return DaoProduct.Read().Select(dbEntity => dbEntity.DbEntityToDomainEntity()).ToList();
        }

        public void Update(int id, DomainEntityProduct domainEntity)
        {
            DbEntityProduct dbEntity = DbEntityProduct.DomainEntityToDbEntity(domainEntity);
            DaoProduct.Update(id, dbEntity);
        }

        public void Delete(int id)
        {
            DaoProduct.Delete(id);
        }
    }
}
