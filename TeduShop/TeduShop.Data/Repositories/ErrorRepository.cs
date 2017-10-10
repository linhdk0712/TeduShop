using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    class ErrorRepository : RepositoryBase<Error>, Interfaces.IErrorRepository
    {
        protected ErrorRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
            
        }
    }
}
