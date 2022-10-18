using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOld.Areas.TeamV.Controllers
{
    public class DefaultController : Controller
    {
        // GET: TeamV/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}