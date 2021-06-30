using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryCrud;

namespace PollosApplication.Src.UseCases.UseCaseCrud
{
    public class UseCaseCrudProduct : UseCaseCrud<DomainEntityProduct>
    {
        public UseCaseCrudProduct(IRepositoryProduct repository) : base(repository)
        {
        }
    }
}
