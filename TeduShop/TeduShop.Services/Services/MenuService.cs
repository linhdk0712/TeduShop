using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Infrastructure.Interfaces;
using TeduShop.Data.Repositories.Interfaces;
using TeduShop.Model.Models;
using TeduShop.Services.Interfaces;

namespace TeduShop.Services.Services{
    

    internal class MenuService : BaseServiceClass<IMenuRepository>, IMenuService
    {
        public MenuService(IMenuRepository t, IUnitOfWork unitOfWork)
            : base(t, unitOfWork)
        {
        }

        public void Add(Menu post)
        {
            BaseService.Add(post);
        }

        public void Delete(int id)
        {
            BaseService.Delete(id);
        }

        public IEnumerable<Menu> GetAll()
        {
            return BaseService.GetAll();
        }

        public IEnumerable<Menu> GetAllPaging(int page, int pageSize, out int totalRows)
        {
            return BaseService.GetMultiPaging(x => x.Status, out totalRows, page, pageSize);
        }

        public Menu GetById(int id)
        {
            return BaseService.GetSingleById(id);
        }

        public void SaveChanges()
        {
            UnitOfWork.Commit();
        }

        public void Update(Menu post)
        {
            BaseService.Update(post);
        }
    }
}