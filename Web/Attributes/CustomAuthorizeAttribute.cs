using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Abstract;

namespace Web.Attributes
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        private readonly IAuthService _auth;
        private readonly string[] _roles;

        public CustomAuthorizeAttribute(params string[] roles)
        {
            _auth = DependencyResolver.Current.GetService<IAuthService>();
            _roles = roles;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            foreach (string role in _roles)
            {
                if (_auth.CheckUserRole(httpContext.User.Identity.Name, role))
                    return true;
            }
            return false;
        }

        //protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        //{
        //    filterContext.Result = new HttpUnauthorizedResult();
        //}
    }
}