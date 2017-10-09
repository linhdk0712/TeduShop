using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{

    public class OrderDetailRepository : RepositoryBase<OrderDetail>, TeduShop.Data.Repositories.Interfaces.IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}