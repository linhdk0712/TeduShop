using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;

namespace TeduShop.Services.Services
{
    public class BaseServiceClass<T> where T : class
    {
        public T baseService;
        public IUnitOfWork _unitOfWork;
        public BaseServiceClass(T t,IUnitOfWork unitOfWork)
        {
            baseService = t;
            _unitOfWork = unitOfWork;
        }
    }
}
