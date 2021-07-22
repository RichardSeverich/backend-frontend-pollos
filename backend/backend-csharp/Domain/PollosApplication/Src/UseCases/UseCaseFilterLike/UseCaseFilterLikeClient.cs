using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilterLike;

namespace PollosApplication.Src.UseCases.UseCaseFilterLike
{
    public class UseCaseFilterLikeClient : UseCaseFilterLike<DomainEntityClient>
    {
        public UseCaseFilterLikeClient(IRepositoryFilterLikeClient repo)
            :base(repo)
        {
        }
    }
}
