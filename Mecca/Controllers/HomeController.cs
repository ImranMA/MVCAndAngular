using Mecca.Common;
using Mecca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Mecca.Controllers
{
    public class HomeController : Controller
    {
        //contoller Action is authorized
        [AuthorizeAttrib]
        public ActionResult Index()
        {
            return View();
        }

        //contoller Action is authorized
        [AuthorizeAttrib]
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Login()
        {
            if (Request.IsAuthenticated)
                return View("Index");
            else
                return View();
        }



    }
}
