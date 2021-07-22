using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilter;

namespace PollosApplication.Src.UseCases.UseCaseFilter
{
    public class UseCaseFilterClient : UseCaseFilter<DomainEntityClient>
    {
        public UseCaseFilterClient(IRepositoryFilterClient repoFilterClient)
            : base(repoFilterClient)
        {
        }
    }
}
