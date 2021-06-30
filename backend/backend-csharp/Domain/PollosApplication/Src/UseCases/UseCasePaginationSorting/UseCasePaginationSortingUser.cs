using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryPaginationSorting;

namespace PollosApplication.Src.UseCases.UseCasePaginationSorting
{
    public class UseCasePaginationSortingUser : UseCasePaginationSorting<DomainEntityUser>
    {
        public UseCasePaginationSortingUser(IRepositoryPaginationSortingUser repository) 
            : base(repository)
        {
        }
    }
}
