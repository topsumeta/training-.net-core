using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Middleware
{
    public class SampleMiddleware
    {

        private readonly RequestDelegate next;

        public SampleMiddleware()
        {
            this.next = next;

        }

        public Task Invoke(HttpContext context)
        {
            return next(context);
        }

    }
}
