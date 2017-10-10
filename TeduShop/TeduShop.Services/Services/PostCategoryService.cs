﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories.Interfaces;
using TeduShop.Model.Models;
using TeduShop.Services.Interfaces;

namespace TeduShop.Services.Services
{
    public class PostCategoryService : BaseServiceClass<IPostCategoryRepository>,IPostCategoryService
    {
        public PostCategoryService(IPostCategoryRepository t, IUnitOfWork unitOfWork) : base(t, unitOfWork)
        {
        }

        public void Add(PostCategory post)
        {
            baseService.Add(post);
        }

        public void Delete(int id)
        {
            baseService.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
           return baseService.GetAll();
        }

        public IEnumerable<PostCategory> GetAllPaging(int page, int pageSize, out int totalRows)
        {
            return baseService.GetMultiPaging(x => x.Status, out totalRows, page, pageSize);
        }

        public PostCategory GetById(int id)
        {
            return baseService.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(PostCategory post)
        {
            baseService.Update(post);
        }
    }
}
