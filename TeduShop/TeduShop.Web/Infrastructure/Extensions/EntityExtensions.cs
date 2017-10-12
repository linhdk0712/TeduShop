﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeduShop.Model.Abstract;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdateAudited(this Auditable auditable, AuditedViewModel auditableVm )
        {
            auditable.CreateBy = auditableVm.CreateBy;
            auditable.CreateDate = auditableVm.CreateDate;
            auditable.MetaDescription = auditableVm.MetaDescription;
            auditable.MetaKeyword = auditableVm.MetaKeyword;
            auditable.Status = auditableVm.Status;
            auditable.UpdateBy = auditableVm.UpdateBy;
            auditable.UpdateDate = auditableVm.UpdateDate;
                
        }
        public static void UpdatePostCategory(this PostCategory postCategory,PostCategoryViewModel postCategoryVm)
        {
            postCategory.ID = postCategoryVm.ID;
            postCategory.Name = postCategoryVm.Name;
            postCategory.Description = postCategoryVm.Description;
            postCategory.Alias = postCategoryVm.Alias;
            postCategory.ParentID = postCategoryVm.ParentID;
            postCategory.DisplayOrder = postCategoryVm.DisplayOrder;
            postCategory.Image = postCategoryVm.Image;
            postCategory.HomeFlag = postCategoryVm.HomeFlag;

        }
        public static void UpdatePostTag(this PostTag postTag , PostTagViewModel postTagVm)
        {
            postTag.TagID = postTagVm.TagID;
            postTag.PostID = postTagVm.PostID;          

        }
        public static void UpdatePost(this Post post, PostViewModel postVm)
        {
            post.ID = postVm.ID;
            post.Name = postVm.Name;
            post.Alias = postVm.Alias;
            post.CategoryID = postVm.CategoryID;
            post.Image = postVm.Image;
            post.Description = postVm.Description;
            post.Content = postVm.Content;
            post.HomeFlag = postVm.HomeFlag;
            post.HotFlag = postVm.HotFlag;
            post.ViewCount = postVm.ViewCount;            

        }
    }
}