using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryPagination;

namespace PollosApplication.Src.UseCases.UseCasePagination
{
    public class UseCasePaginationProduct : UseCasePagination<DomainEntityProduct>
    {
        public UseCasePaginationProduct(IRepositoryPaginationProduct repository) : base(repository)
        {
        }
    }
}
