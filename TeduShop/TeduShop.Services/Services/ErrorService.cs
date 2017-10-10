using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Repositories;
using TeduShop.Data.Repositories.Interfaces;
using TeduShop.Services.Interfaces;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Services.Services
{
    public class ErrorService : BaseServiceClass<IErrorRepository>, IErrorService
    {
        public ErrorService(IErrorRepository t, IUnitOfWork unitOfWork)
            : base(t, unitOfWork)
        {
            
        }

        public void Add(Error post)
        {
            baseService.Add(post);
        }

        public void Delete(int id)
        {
            baseService.Delete(id);
        }

        public IEnumerable<Error> GetAll()
        {
            return baseService.GetAll();
        }

        public IEnumerable<Error> GetAllPaging(int page, int pageSize, out int totalRows)
        {
            return baseService.GetMultiPaging(x => x.Status, out totalRows, page, pageSize);
        }

        public Error GetById(int id)
        {
            return baseService.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Error post)
        {
            throw new NotImplementedException();
        }
    }
}
