using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories.Interfaces;
using TeduShop.Model.Models;
using TeduShop.Services.Interfaces;

namespace TeduShop.Services.Services
{
    public class MenuGroupService : BaseServiceClass<IMenuGroupRepository>, IMenuGroupService
    {
        public MenuGroupService(IMenuGroupRepository t, IUnitOfWork unitOfWork) : base(t, unitOfWork)
        {
        }

        public void Add(MenuGroup post)
        {
            BaseService.Add(post);
        }

        public void Delete(int id)
        {
            BaseService.Delete(id);
        }

        public IEnumerable<MenuGroup> GetAll()
        {
            return BaseService.GetAll();
        }

        public IEnumerable<MenuGroup> GetAllPaging(int page, int pageSize, out int totalRows)
        {
            return BaseService.GetMultiPaging(x => x.Status, out totalRows, page, pageSize);
        }

        public MenuGroup GetById(int id)
        {
            return BaseService.GetSingleById(id);
        }

        public void SaveChanges()
        {
            UnitOfWork.Commit();
        }

        public void Update(MenuGroup post)
        {
            BaseService.Update(post);
        }
    }
}
