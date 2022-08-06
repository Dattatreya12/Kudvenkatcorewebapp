using Kudvenkatcorewebapp.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.CustonMiddleware
{
    public class ExceptinMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ExceptinMiddleware> _logger;
        private readonly IHostEnvironment _env;
        

        public ExceptinMiddleware(RequestDelegate next,ILogger<ExceptinMiddleware> logger,IHostEnvironment env)
        {
            this.next = next;
            this._logger = logger;
            _env = env;
           
        }

      

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch(Exception ex)
            {
                ErrorHandling response;
                HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
                string Message = string.Empty;
                var exceptionType = ex.GetType();
                if(exceptionType==typeof(UnauthorizedAccessException))
                {
                    statusCode = HttpStatusCode.Forbidden;
                    Message = "you are not Authorized";
                }
                else
                {
                    statusCode = HttpStatusCode.InternalServerError;
                    Message = "Some Error Ocurred";
                }

                if(_env.IsDevelopment())
                {
                    response = new ErrorHandling((int)statusCode, ex.Message, ex.StackTrace.ToString());
                    UseDeveloperExceptionPage();
                }
                else
                {
                    response = new ErrorHandling((int)statusCode, ex.Message);
                    UseExceptionHandler("/Home/Error");

                }
                _logger.LogError(ex, ex.Message);
                context.Response.StatusCode = (int)statusCode;
                
                await context.Response.WriteAsync(ex.Message);
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(response.ToString());
                //app.UseExceptionHandler("/Home/Error");
              
            }
        }

        private void UseDeveloperExceptionPage()
        {
            throw new NotImplementedException();
        }

        private void UseExceptionHandler(string v)
        {
            throw new NotImplementedException();
        }
    }
}
