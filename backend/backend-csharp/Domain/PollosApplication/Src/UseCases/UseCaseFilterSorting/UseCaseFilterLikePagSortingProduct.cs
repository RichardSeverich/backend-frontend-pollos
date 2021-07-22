using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilterPagSorting;

namespace PollosApplication.Src.UseCases.UseCaseFilterSorting
{
    public class UseCaseFilterLikePagSortingProduct : UseCaseFilterLikePagSorting<DomainEntityProduct>
    {
        public UseCaseFilterLikePagSortingProduct(IRepositoryFilterLikePagSortingProduct repo)
            :base(repo)
        {
        }
    }
}
