using TeduShop.Data.Infrastructure;
using TeduShop.Data.Infrastructure.Interfaces;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{

    public class VisitorStatisticRepository : RepositoryBase<VisitorStatistic>, TeduShop.Data.Repositories.Interfaces.IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}