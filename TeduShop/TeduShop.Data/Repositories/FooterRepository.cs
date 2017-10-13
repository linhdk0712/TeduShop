using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories.Interfaces;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public class FooterRepository : RepositoryBase<Footer>,IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
            
        }
    }
}
