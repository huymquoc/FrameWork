using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Framework.Web.Service;

namespace Framework.Web.Controllers
{
    public class HomeController : Controller
    {
        private IService _baseService;

        public HomeController(IService baseService)
        {
            _baseService = baseService;
        }

        public ActionResult Index()
        {
           // _baseService.DoSomething();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}