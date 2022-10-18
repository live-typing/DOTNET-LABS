using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcOld
{
    public class LogFilter :  ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("In On Action Executing", filterContext.RouteData);
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log("In On Action Executed", filterContext.RouteData);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log("In On Result Executed", filterContext.RouteData);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log("In On Result Executed",filterContext.RouteData);
            filterContext.Controller.ViewBag.Message = "A new status";
        }

        public void Log(string msg, RouteData context)
        {
            Debug.WriteLine(msg);
            Debug.WriteLine("Details : {0}, ControllerName: {1} , ActionName: {2}",
                msg, context.Values["Controllers"], context.Values["action"]);        }
    }
}