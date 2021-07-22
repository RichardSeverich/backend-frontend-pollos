using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryCrud;

namespace PollosApplication.Src.UseCases.UseCaseCrud
{
    public class UseCaseCrudUser : UseCaseCrud<DomainEntityUser>
    {
        public UseCaseCrudUser(IRepositoryUser repository) : base(repository)
        {
        }
    }
}
