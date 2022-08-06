using Kudvenkatcorewebapp.CustonMiddleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Extensions
{
    public static class ExceptionsMiddlewareExtensions
    {

        public static void ConfigureExceptionHandler(this IApplicationBuilder app, IWebHostEnvironment env)
        {
              
            app.UseMiddleware<ExceptinMiddleware>();
            app.UseExceptionHandler("/Home/Error");
        }
            public static void ConfigureBuiltInExceptionHandler(this IApplicationBuilder app,IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(
                    options =>
                    {
                        options.Run(
                            async context =>
                            {
                                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                                var ex = context.Features.Get<IExceptionHandlerFeature>();
                                if (ex != null)
                                {
                                    app.UseExceptionHandler("/Home/Error");
                                    await context.Response.WriteAsync(ex.Error.Message);
                                    
                                }

                            });

                    });
            }
        }
    }
}
