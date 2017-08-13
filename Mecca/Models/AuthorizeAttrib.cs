using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls;

namespace Mecca.Models
{
    //Authorize attribute is override here
    public class AuthorizeAttrib : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext context)
        {        

            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                base.HandleUnauthorizedRequest(context);
            }
            else
            {
                context.Result = new RedirectToRouteResult(new
                RouteValueDictionary(new { controller = "Home", action = "Login" }));
            }
        }
    }
}