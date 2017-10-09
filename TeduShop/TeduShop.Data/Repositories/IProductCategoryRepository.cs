using System;
using System.Collections.Generic;
using System.Linq;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    internal interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
}
