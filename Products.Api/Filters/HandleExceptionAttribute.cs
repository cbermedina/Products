using Microsoft.AspNetCore.Mvc.Filters;
using Products.Api.Business;
using Products.Api.CrossCutting.Interface;
using System.Diagnostics;

namespace Products.Api.Filters
{
    public class HandleExceptionAttribute: ExceptionFilterAttribute
    {
        private readonly IServiceLog _serviceLog;
        public HandleExceptionAttribute(IServiceLog serviceLog)
        {
            _serviceLog = serviceLog;
        }
        #region Methods
        /// <summary>
        /// On Exception
        /// </summary>
        /// <param name="context"></param>
        public override void OnException(ExceptionContext context)
        {
            var lastException = context.Exception.GetBaseException();

            var isException = lastException as NotificationException;
            _serviceLog.WriteError(isException.ClassName, isException.Method, isException.Exception);
            context.ExceptionHandled = true;
            context.HttpContext.Response.StatusCode = 500;
            base.OnException(context);
        }

        #endregion
    }
}
