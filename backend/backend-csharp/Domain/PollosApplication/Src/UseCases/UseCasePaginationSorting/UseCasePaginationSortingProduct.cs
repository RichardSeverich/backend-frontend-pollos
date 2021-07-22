using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryPaginationSorting;

namespace PollosApplication.Src.UseCases.UseCasePaginationSorting
{
    public class UseCasePaginationSortingProduct : UseCasePaginationSorting<DomainEntityProduct>
    {
        public UseCasePaginationSortingProduct(IRepositoryPaginationSortingProduct repository) 
            : base(repository)
        {
        }
    }
}
