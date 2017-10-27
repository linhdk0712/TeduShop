 using TeduShop.Data.Infrastructure;
 using TeduShop.Data.Infrastructure.Interfaces;
 using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{

    public class TagRepository : RepositoryBase<Tag>, Interfaces.ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}