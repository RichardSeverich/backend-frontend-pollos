using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilterPagSorting;

namespace PollosApplication.Src.UseCases.UseCaseFilterSorting
{
    public class UseCaseFilterLikePagSortingClient : UseCaseFilterLikePagSorting<DomainEntityClient>
    {
        public UseCaseFilterLikePagSortingClient(IRepositoryFilterLikePagSortingClient repo)
            :base(repo)
        {
        }
    }
}
