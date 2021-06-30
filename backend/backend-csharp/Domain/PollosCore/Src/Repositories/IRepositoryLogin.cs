using PollosCore.Src.DomainEntities;

namespace PollosCore.Src.Repositories
{
    public interface IRepositoryLogin
    {
        DomainEntityUser FindUserForLogin(string username, string password);
    }
}
