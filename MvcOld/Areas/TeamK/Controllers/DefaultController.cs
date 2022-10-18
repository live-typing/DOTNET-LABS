using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOld.Areas.TeamK.Controllers
{
    public class DefaultController : Controller
    {
        // GET: TeamK/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}