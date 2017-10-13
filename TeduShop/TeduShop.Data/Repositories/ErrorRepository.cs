using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public class ErrorRepository : RepositoryBase<Error>, Interfaces.IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
            
        }
    }
}
