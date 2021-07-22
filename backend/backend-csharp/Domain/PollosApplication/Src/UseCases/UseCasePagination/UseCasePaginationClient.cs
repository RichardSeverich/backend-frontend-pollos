using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryPagination;

namespace PollosApplication.Src.UseCases.UseCasePagination
{
    public class UseCasePaginationClient : UseCasePagination<DomainEntityClient>
    {
        public UseCasePaginationClient(IRepositoryPaginationClient repository) : base(repository)
        {
        }
    }
}
