using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilterLike;

namespace PollosApplication.Src.UseCases.UseCaseFilterLike
{
    public class UseCaseFilterLikeUser : UseCaseFilterLike<DomainEntityUser>
    {
        public UseCaseFilterLikeUser(IRepositoryFilterLikeUser repo)
            :base(repo)
        {
        }
    }
}
