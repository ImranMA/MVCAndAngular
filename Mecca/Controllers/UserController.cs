using Mecca.Common;
using Mecca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace Mecca.Controllers
{
    public class UserController : Controller
    {
        
        //User SignIn Method returns the status code and message
        [HttpPost]
        public ActionResult SignIn(UserModel user)
        {
            try
            {            

                if (this.ModelState.IsValid)
                {
                    var authenticated = new UserModel().AuthenticateUser(user);
                   
                    if (authenticated)
                    {
                        var response = new HttpStatusCodeResult(HttpStatusCode.Created);
                        FormsAuthentication.SetAuthCookie(user.UserName, true);
                        return response;
                    }
                    else
                    {                    
                        
                        return new HttpStatusCodeResult(HttpStatusCode.Forbidden, Common.ErrorCodes.INVALID_USER_NAME);
                    }
                }
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, Common.ErrorCodes.INVALID_REQUEST);

            }
            catch (Exception ex)
            {
                //Errors are logged in the File Mecca.log
                Logging.Error(ex.Message.ToString());
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, Common.ErrorCodes.INVALID_REQUEST);
            }

        }



        //User SignOut return the status codes and messages
        [HttpPost]
        public ActionResult SignOut(UserModel user)
        {
            try
            {
                if (this.ModelState.IsValid)
                {
                    Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.Cache.SetNoStore();

                    var response = new HttpStatusCodeResult(HttpStatusCode.Created);
                    FormsAuthentication.SignOut();
                    return response;
                }
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {

                //Errors are logged in the File Mecca.log
                Logging.Error(ex.Message.ToString());
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
          
        }

    }


}