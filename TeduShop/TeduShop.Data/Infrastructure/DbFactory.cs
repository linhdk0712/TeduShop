using TeduShop.Data.Infrastructure.Interfaces;

namespace TeduShop.Data.Infrastructure
{
    public abstract class DbFactory : Disposable, IDbFactory
    {
        private TeduShopDbContext _dbContext;

        public TeduShopDbContext Init()
        {
            return _dbContext ?? (_dbContext = new TeduShopDbContext());
        }

        protected override void DisposeCore()
        {
            _dbContext?.Dispose();
        }
    }
}