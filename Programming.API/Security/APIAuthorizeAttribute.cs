using Programming.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Programming.API.Security
{
    public class APIAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var actionRoles = Roles;
            var userName = HttpContext.Current.User.Identity.Name;

            UsersDAL usersDAL = new UsersDAL();
            var user = usersDAL.GetUserByName(userName);

            if (user == null || !actionRoles.Contains(user.role))
                actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
        }
    }
}