using System;
using System.Collections.Generic;
using TeduShop.Data.Repositories.Interfaces;
using TeduShop.Services.Interfaces;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Infrastructure.Interfaces;
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
            BaseService.Add(post);
        }

        public void Delete(int id)
        {
            BaseService.Delete(id);
        }

        public IEnumerable<Error> GetAll()
        {
            return BaseService.GetAll();
        }

        public IEnumerable<Error> GetAllPaging(int page, int pageSize, out int totalRows)
        {
            return BaseService.GetMultiPaging(x => x.Status, out totalRows, page, pageSize);
        }

        public Error GetById(int id)
        {
            return BaseService.GetSingleById(id);
        }

        public void SaveChanges()
        {
            UnitOfWork.Commit();
        }

        public void Update(Error post)
        {
            throw new NotImplementedException();
        }
    }
}
