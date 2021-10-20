using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5.Middleware
{
    public class CookieMiddleWare
    {
        private readonly RequestDelegate _next;

        public CookieMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var counter = int.Parse(context.Request.Cookies["counter"] ?? "0") + 1;

            context.Response.Cookies.Append("counter", counter.ToString(), new CookieOptions()
            {
                
            });

            await context.Response.WriteAsync($"{counter} \n");
            await _next(context);
        }

    }
}
