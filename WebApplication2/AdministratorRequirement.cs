using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class AdministratorRequirement : AuthorizationHandler<AdministratorRequirement>, IAuthorizationRequirement
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AdministratorRequirement requirement)
        {
           

            if(context.Resource is AuthorizationFilterContext filterContext)
            {
                var session = filterContext.HttpContext.Session;
                var userId = session.GetString("username");
                if (string.IsNullOrEmpty(userId) == false) {
                    context.Succeed(requirement);
                }
            }
            return Task.CompletedTask;
        }
    }
}
