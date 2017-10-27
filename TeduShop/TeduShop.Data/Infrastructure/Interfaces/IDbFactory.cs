using System;

namespace TeduShop.Data.Infrastructure.Interfaces
{
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();
    }
}