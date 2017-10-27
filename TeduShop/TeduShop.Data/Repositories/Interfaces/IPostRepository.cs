using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Infrastructure.Interfaces;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories.Interfaces
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int page, int pageSize, out int totalRows);
    }
}
