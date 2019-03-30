using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc;
using VidlyAppy.Filters;
using VidlyAppy.Models;

namespace VidlyAppy.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            return View();
        }

        [MyActionFilter]
        public ActionResult About()
        {
            try
            {
                var index = Division(100, 10);
                
                ViewBag.Message = "Your application description page: " + index;
            }

            catch (DivideByZeroException ex)
            {               
                ViewBag.Message = "Your application description page: " + ex.Message;
            }
            catch (Exception ex)
            {

                //throw new DivideByZeroException(ex.Message);
                ViewBag.Message = "Your application error page: " + ex.Message;
            }
            finally
            {
                ViewBag.Name = "Your application.";
            } 
                                 
            return View();
        }
        
        public int Division(int a, int b)
        {
            var result = 0;
            try
            {
               return result = a / b;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Error()
        {
            return View("Error");
        }
       

      
        
    }
}