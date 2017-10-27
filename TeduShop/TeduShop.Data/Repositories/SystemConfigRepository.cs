using TeduShop.Data.Infrastructure;
using TeduShop.Data.Infrastructure.Interfaces;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{

    public class SystemConfigRepository : RepositoryBase<SystemConfig>, TeduShop.Data.Repositories.Interfaces.ISystemConfigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}