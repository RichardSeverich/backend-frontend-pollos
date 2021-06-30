using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilter;
using PollosDatabase.Src.Dao.DaoFilter;
using PollosDatabase.Src.DbEntities;
using System.Collections.Generic;
using System.Linq;

namespace PollosDatabase.Src.Repositories.RepositoryFilter
{
    public class RepositoryFilterClient : IRepositoryFilterClient
    {
        public List<DomainEntityClient> Filter(List<string> columnsValuesToFilter)
        {
            return DaoFilterGeneric.Filter<DbEntityClient>(columnsValuesToFilter)
                .Select(dbEntity => dbEntity.DbEntityToDomainEntity())
                .ToList();
        }
    }
}
