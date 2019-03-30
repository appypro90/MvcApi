using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VidlyAppy.Filters
{
    public class MyActionFilterAttribute : ActionFilterAttribute
    {
        
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //System.Web.Routing.RouteData = filterContext.RouteData;
            trace("OnActionExecuting",filterContext.RouteData);
            
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            trace("OnActionExecuted", filterContext.RouteData);
            
        }

        private void trace(string methodName, System.Web.Routing.RouteData routeData)
        {
            string MethodName = methodName;
            string controllerName = routeData.Values["controller"].ToString();
            string ActionMethodName = routeData.Values["action"].ToString();
            HttpContext.Current.Response.Write($"Method  Name = {MethodName}, Controller Name = {controllerName}, Action Method Name = {ActionMethodName} <br><br>");

        }

  

    }

}