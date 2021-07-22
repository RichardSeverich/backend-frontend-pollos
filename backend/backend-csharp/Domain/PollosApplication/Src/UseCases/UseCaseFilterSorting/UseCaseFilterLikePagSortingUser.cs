using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilterPagSorting;

namespace PollosApplication.Src.UseCases.UseCaseFilterSorting
{
    public class UseCaseFilterLikePagSortingUser : UseCaseFilterLikePagSorting<DomainEntityUser>
    {
        public UseCaseFilterLikePagSortingUser(IRepositoryFilterLikePagSortingUser repo)
            :base(repo)
        {
        }
    }
}
