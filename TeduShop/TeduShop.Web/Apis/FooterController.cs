using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Web.Infrastructure.Core;
using TeduShop.Services.Interfaces;
using TeduShop.Services;

namespace TeduShop.Web.Apis
{
    [RoutePrefix("api/footer")]
    public class FooterController : ApiBaseController
    {
        private IFooterService _footerServices;
        public FooterController(IErrorService errorService, IFooterService footerServices)
            : base(errorService)
        {
            this._footerServices = footerServices;
        }
        [Route("getalldata")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
             {
                 var result = _footerServices.GetAll();
                 var response = request.CreateResponse(HttpStatusCode.OK, result);

                 return response;
             });
        }
    }
}
