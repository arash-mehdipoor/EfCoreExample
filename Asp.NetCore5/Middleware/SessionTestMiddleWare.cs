using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5.Middleware
{
    public class SessionTestMiddleWare
    {
        private readonly RequestDelegate _next;

        public SessionTestMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var counter = context.Session.GetInt32("counter") ?? 0;

            context.Session.SetInt32("counter", counter);
            await context.Session.CommitAsync();

            await context.Response.WriteAsync($"{counter} \n");
            await _next(context);
        }

    }
}
