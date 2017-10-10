using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Web.Infrastructure.Core;
using TeduShop.Services.Interfaces;
using TeduShop.Model.Models;

namespace TeduShop.Web.Apis
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiBaseController
    {
        IPostCategoryService _postCategorySevice;
        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategorySevice)
            : base(errorService)
        {
            this._postCategorySevice = postCategorySevice;
        }
        [Route("getalldata")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
             {
                 HttpResponseMessage response = null;
                 if (ModelState.IsValid)
                 {
                     request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                 }
                 else
                 {
                     var result =_postCategorySevice.GetAll();                     
                     response = request.CreateResponse(HttpStatusCode.OK,result);
                 }
                 return response;
             });
        }
        [Route("addnew")]
        public HttpResponseMessage Post(HttpRequestMessage request,PostCategory postCategory)
        {
            return CreateHttpResponse(request, () =>
             {
                 HttpResponseMessage response = null;
                 if(ModelState.IsValid)
                 {
                     request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                 }
                 else
                 {
                     _postCategorySevice.Add(postCategory);
                     _postCategorySevice.SaveChanges();
                     response = request.CreateResponse(HttpStatusCode.OK);
                 }
                 return response;
             });
        }
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, PostCategory postCategory)
        {
            return CreateHttpResponse(request, () =>
             {
                 HttpResponseMessage response = null;
                 if (ModelState.IsValid)
                 {
                     request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                 }
                 else
                 {
                     _postCategorySevice.Update(postCategory);
                     _postCategorySevice.SaveChanges();
                     response = request.CreateResponse(HttpStatusCode.OK);
                 }
                 return response;
             });
        }
        [Route("remove")]
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
             {
                 HttpResponseMessage response = null;
                 if (ModelState.IsValid)
                 {
                     request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                 }
                 else
                 {
                     _postCategorySevice.Delete(id);
                     _postCategorySevice.SaveChanges();
                     response = request.CreateResponse(HttpStatusCode.OK);
                 }
                 return response;
             });
        }

    }
}
