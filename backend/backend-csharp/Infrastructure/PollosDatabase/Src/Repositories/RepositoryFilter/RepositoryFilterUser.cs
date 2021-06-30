using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilter;
using PollosDatabase.Src.Dao.DaoFilter;
using PollosDatabase.Src.DbEntities;
using System.Collections.Generic;
using System.Linq;

namespace PollosDatabase.Src.Repositories.RepositoryFilter
{
    public class RepositoryFilterUser : IRepositoryFilterUser
    {
        public List<DomainEntityUser> Filter(List<string> columnsValuesToFilter)
        {
            return DaoFilterGeneric.Filter<DbEntityUser>(columnsValuesToFilter)
                .Select(dbEntity => dbEntity.DbEntityToDomainEntity())
                .ToList();
        }
    }
}
