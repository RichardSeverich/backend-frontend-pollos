using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories;

namespace PollosApplication.Src.UseCases
{
    public class UseCaseLogin
    {
        private IRepositoryLogin _repositoryLogin;

        public UseCaseLogin(IRepositoryLogin repository)
        {
            _repositoryLogin = repository;
        }

        public DomainEntityUser FindUserForLogin(string username, string password)
        {
            return _repositoryLogin.FindUserForLogin(username, password);
        }
    }
}
