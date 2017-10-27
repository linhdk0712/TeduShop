using System;
using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Infrastructure.Interfaces;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories.Interfaces
{
    internal interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
}
