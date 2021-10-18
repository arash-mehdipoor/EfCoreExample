using Asp.NetCore5.Repasitory;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5.Middleware
{
    public class RequestCultureMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestCultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync("RequestCultureMiddleware");
            await _next(context);
        }
    }

    public class TransientMiddleware
    {
        private readonly RequestDelegate _next;

        public TransientMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task InvokeAsync(HttpContext context,ITransient transient01, ITransient transient02)
        {
            await context.Response.WriteAsync($"{transient01.GetId()} \n");
            await context.Response.WriteAsync($"{transient02.GetId()} \n");
            await _next(context);
        }
    }
}
