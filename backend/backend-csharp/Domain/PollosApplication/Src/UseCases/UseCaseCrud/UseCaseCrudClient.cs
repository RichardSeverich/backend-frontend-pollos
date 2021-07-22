using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryCrud;

namespace PollosApplication.Src.UseCases.UseCaseCrud
{
    public class UseCaseCrudClient : UseCaseCrud<DomainEntityClient>
    {
        public UseCaseCrudClient(IRepositoryClient repository) : base(repository)
        {
        }
    }
}
