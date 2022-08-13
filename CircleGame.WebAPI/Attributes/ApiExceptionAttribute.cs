using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace CircleGame.WebAPI.Attributes
{
    public class ApiExceptionAttribute : ExceptionFilterAttribute
    {
        HttpResponseMessage responseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.NotImplemented);
        
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            responseMessage.ReasonPhrase = actionExecutedContext.Exception.Message;
            actionExecutedContext.Response = responseMessage;

            base.OnException(actionExecutedContext);
        }
    }
}