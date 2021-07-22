using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilterLike;

namespace PollosApplication.Src.UseCases.UseCaseFilterLike
{
    public class UseCaseFilterLikeProduct : UseCaseFilterLike<DomainEntityProduct>
    {
        public UseCaseFilterLikeProduct(IRepositoryFilterLikeProduct repo)
            :base(repo)
        {
        }
    }
}
