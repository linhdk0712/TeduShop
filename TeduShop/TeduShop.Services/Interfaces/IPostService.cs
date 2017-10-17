using System.Collections.Generic;
using TeduShop.Model.Models;

namespace TeduShop.Services.Interfaces
{
    public interface IPostService : IBaseService<Post>
    {
        IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);
        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
    }
}
