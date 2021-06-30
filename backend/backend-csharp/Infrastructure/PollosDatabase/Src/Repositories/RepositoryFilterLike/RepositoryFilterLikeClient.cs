using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilterLike;
using PollosDatabase.Src.Dao.DaoFilter;
using PollosDatabase.Src.DbEntities;
using System.Collections.Generic;
using System.Linq;

namespace PollosDatabase.Src.Repositories.RepositoryFilterLike
{
    public class RepositoryFilterLikeClient : IRepositoryFilterLikeClient
    {
        public List<DomainEntityClient> FilterLike(List<string> listToFilter)
        {
            return DaoFilterLikeGeneric.Filter<DbEntityClient>(listToFilter)
                .Select(dbEntity => dbEntity.DbEntityToDomainEntity())
                .ToList();
        }
    }
}
