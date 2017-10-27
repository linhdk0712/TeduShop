using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Infrastructure.Interfaces;
using TeduShop.Data.Repositories.Interfaces;
using TeduShop.Model.Models;
using TeduShop.Services.Interfaces;

namespace TeduShop.Services.Services
{
    public class PostCategoryService : BaseServiceClass<IPostCategoryRepository>,IPostCategoryService
    {
        public PostCategoryService(IPostCategoryRepository t, IUnitOfWork unitOfWork) : base(t, unitOfWork)
        {
        }

        public void Add(PostCategory post)
        {
            BaseService.Add(post);
        }

        public void Delete(int id)
        {
            BaseService.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
           return BaseService.GetAll();
        }

        public IEnumerable<PostCategory> GetAllPaging(int page, int pageSize, out int totalRows)
        {
            return BaseService.GetMultiPaging(x => x.Status, out totalRows, page, pageSize);
        }

        public PostCategory GetById(int id)
        {
            return BaseService.GetSingleById(id);
        }

        public void SaveChanges()
        {
            UnitOfWork.Commit();
        }

        public void Update(PostCategory post)
        {
            BaseService.Update(post);
        }
    }
}
