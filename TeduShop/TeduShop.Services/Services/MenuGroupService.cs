using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            baseService.Add(post);
        }

        public void Delete(int id)
        {
            baseService.Delete(id);
        }

        public IEnumerable<MenuGroup> GetAll()
        {
            return baseService.GetAll();
        }

        public IEnumerable<MenuGroup> GetAllPaging(int page, int pageSize, out int totalRows)
        {
            throw new NotImplementedException();
        }

        public MenuGroup GetById(int id)
        {
            return baseService.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(MenuGroup post)
        {
            baseService.Update(post);
        }
    }
}
