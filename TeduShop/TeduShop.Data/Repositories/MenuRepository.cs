using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public class MenuRepository : RepositoryBase<Menu>,TeduShop.Data.Repositories.Interfaces.IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
            
        }
    }
}
