using TeduShop.Data.Infrastructure;
using TeduShop.Data.Infrastructure.Interfaces;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{

    public class PostCategoryRepository : RepositoryBase<PostCategory>, Interfaces.IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}