using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Model.Models;
using TeduShop.Services.Interfaces;

namespace TeduShop.Web.Infrastructure.Core
{
    public class ApiBaseController : ApiController
    {
        private IErrorService _errorService;
        public ApiBaseController( IErrorService errorService)
        {
            _errorService = errorService;
        }
        //TODO: Catch log to write 
        protected HttpResponseMessage CreateHttpResponse(HttpRequestMessage requestMessage, Func<HttpResponseMessage> function)
        {
            HttpResponseMessage response = null;
           
            try
            {
                response = function.Invoke();
            }
            catch(DbEntityValidationException ex)
            {
                foreach (var item in ex.EntityValidationErrors)
                {
                    Trace.WriteLine($"Entity of type -- {item.Entry.Entity.GetType().Name} -- in state -- {item.Entry.State}");
                    foreach (var eve in item.ValidationErrors)
                    {
                        Trace.WriteLine($"Property -- {eve.PropertyName} -- Error -- {eve.ErrorMessage}");
                    }
                }
                LogError(ex);
                response = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
            catch(DbUpdateException dbEx)
            {
                LogError(dbEx);
                response = requestMessage.CreateResponse(HttpStatusCode.BadRequest, dbEx.InnerException.Message);
            }
            catch (Exception ex)
            {

                LogError(ex);
                response = requestMessage.CreateResponse(HttpStatusCode.BadRequest,ex.Message);
            }
            return response;

        }
        //TODO : Write log to dabase
        private void LogError(Exception ex)
        {
            try
            {
                Error error = new Error() { CreateDate = DateTime.Now, Message = ex.Message, StackTrace = ex.StackTrace, Status = true };
                _errorService.Add(error);
                _errorService.SaveChanges();
            }
            catch 
            {

               
            }
        }
        
    }
}