using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace Programming.API.Attributes
{
    public class ApiExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            HttpResponseMessage errorResponse = new HttpResponseMessage(System.Net.HttpStatusCode.NotImplemented);
            errorResponse.ReasonPhrase = actionExecutedContext.Exception.Message;
            actionExecutedContext.Response = errorResponse;
            base.OnException(actionExecutedContext);
        }
    }
}