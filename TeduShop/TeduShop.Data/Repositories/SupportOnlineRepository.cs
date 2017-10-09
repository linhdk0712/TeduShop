using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{

    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, TeduShop.Data.Repositories.Interfaces.ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}