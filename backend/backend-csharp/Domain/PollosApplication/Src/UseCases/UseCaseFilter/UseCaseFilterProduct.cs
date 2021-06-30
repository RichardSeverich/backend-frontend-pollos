using PollosCore.Src.DomainEntities;
using PollosCore.Src.Repositories.RepositoryFilter;

namespace PollosApplication.Src.UseCases.UseCaseFilter
{
    public class UseCaseFilterProduct : UseCaseFilter<DomainEntityProduct>
    {
        public UseCaseFilterProduct(IRepositoryFilterProduct repoFilterProduct)
            : base(repoFilterProduct)
        {
        }
    }
}
