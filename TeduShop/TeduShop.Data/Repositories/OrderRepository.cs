﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Infrastructure.Interfaces;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public class OrderRepository : RepositoryBase<Order>
    {
        public OrderRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
            
        }
    }
}
