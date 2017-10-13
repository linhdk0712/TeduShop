using TeduShop.Data.Infrastructure;

namespace TeduShop.Services.Services
{
    public class BaseServiceClass<T> where T : class
    {
        protected readonly T BaseService;
        protected readonly IUnitOfWork UnitOfWork;

        protected BaseServiceClass(T t,IUnitOfWork unitOfWork)
        {
            BaseService = t;
            UnitOfWork = unitOfWork;
        }
    }
}
