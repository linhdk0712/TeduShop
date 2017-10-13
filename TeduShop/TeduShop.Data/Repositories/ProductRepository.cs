using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>,TeduShop.Data.Repositories.Interfaces.IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
            
        }
    }
}
