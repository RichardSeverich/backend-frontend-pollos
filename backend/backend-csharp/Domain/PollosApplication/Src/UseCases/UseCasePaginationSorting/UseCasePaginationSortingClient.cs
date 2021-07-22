using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryPaginationSorting;

namespace PollosApplication.Src.UseCases.UseCasePaginationSorting
{
    public class UseCasePaginationSortingClient : UseCasePaginationSorting<DomainEntityClient>
    {
        public UseCasePaginationSortingClient(IRepositoryPaginationSortingClient repository) 
            : base(repository)
        {
        }
    }
}
