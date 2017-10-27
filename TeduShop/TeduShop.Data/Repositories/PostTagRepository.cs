using TeduShop.Data.Infrastructure;
using TeduShop.Data.Infrastructure.Interfaces;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{

    public class PostTagRepository : RepositoryBase<PostTag>, TeduShop.Data.Repositories.Interfaces.IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}