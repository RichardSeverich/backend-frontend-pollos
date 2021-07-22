using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories;
using PollosDatabase.Src.Dao;
using PollosDatabase.Src.DbEntities;

namespace PollosDatabase.Src.Repositories
{
    public class RepositoryLogin : IRepositoryLogin
    {
        public DomainEntityUser FindUserForLogin(string username, string password)
        {
            DbEntityUser dbEntity = DaoLogin.FindByUsernamePassword(username, password);
            return (dbEntity == null) 
                ? null 
                : dbEntity.DbEntityToDomainEntity();
        }
    }
}
