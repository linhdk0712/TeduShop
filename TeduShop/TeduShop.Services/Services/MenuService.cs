﻿using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories.Interfaces;
using TeduShop.Model.Models;
using TeduShop.Services.Interfaces;

namespace TeduShop.Services.Services{
    

    internal class MenuService : BaseServiceClass<IMenuRepository>, IMenuService
    {
        public MenuService(IMenuRepository t, IUnitOfWork unitOfWork)
            : base(t, unitOfWork)
        {
        }

        public void Add(Menu post)
        {
            baseService.Add(post);
        }

        public void Delete(int id)
        {
            baseService.Delete(id);
        }

        public IEnumerable<Menu> GetAll()
        {
            return baseService.GetAll();
        }

        public IEnumerable<Menu> GetAllPaging(int page, int pageSize, out int totalRows)
        {
            return baseService.GetMultiPaging(x => x.Status, out totalRows, page, pageSize);
        }

        public Menu GetById(int id)
        {
            return baseService.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Menu post)
        {
            baseService.Update(post);
        }
    }
}