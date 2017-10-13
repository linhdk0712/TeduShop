using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public class MenuGroupRepository : RepositoryBase<MenuGroup>,TeduShop.Data.Repositories.Interfaces.IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
            
        }
    }
}
