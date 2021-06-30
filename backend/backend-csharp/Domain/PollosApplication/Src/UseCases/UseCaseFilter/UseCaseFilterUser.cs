using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilter;

namespace PollosApplication.Src.UseCases.UseCaseFilter
{
    public class UseCaseFilterUser : UseCaseFilter<DomainEntityUser>
    {
        public UseCaseFilterUser(IRepositoryFilterUser repoFilterUser)
            : base(repoFilterUser)
        {
        }
    }
}
