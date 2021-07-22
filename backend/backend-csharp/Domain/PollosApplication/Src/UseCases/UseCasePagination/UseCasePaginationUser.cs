using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryPagination;

namespace PollosApplication.Src.UseCases.UseCasePagination
{
    public class UseCasePaginationUser : UseCasePagination<DomainEntityUser>
    {
        public UseCasePaginationUser(IRepositoryPaginationUser repository) : base(repository)
        {
        }
    }
}
