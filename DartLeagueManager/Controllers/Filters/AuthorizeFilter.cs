using DartLeagueManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace DartLeagueManager.Controllers.Filters
{
    public class ClaimRequirementAttribute : TypeFilterAttribute
    {
        public ClaimRequirementAttribute(string claimType, string claimValue) : base(typeof(ClaimRequirementFilter))
        {
            Arguments = new object[] { new Claim(claimType, claimValue) };
        }
    }

    public class ClaimRequirementFilter : IAuthorizationFilter
    {
        readonly Claim _claim;

        public ClaimRequirementFilter(Claim claim)
        {
            _claim = claim;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var hasClaim = context.HttpContext.User.Claims.Any(c => c.Type == _claim.Type && c.Value == _claim.Value);
        }


    }
    public class AuthorizeFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            User user = context.HttpContext.Session.Get<User>(Resources.SessionUser);
            List<Role> roles = context.HttpContext.Session.Get<List<Role>>(Resources.SessionRoles);
            Role adminRole = null;
            if (roles != null)
            {
                adminRole = roles.FirstOrDefault(r => r.Name == "admin");
            }



            if (user == null || adminRole == null)
            {
                //return RedirectToAction("Error", "Home", new { exception = new Exception("Not Authorized!") });
            }

        }
    }
}
