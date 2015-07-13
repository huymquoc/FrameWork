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
        private ILibraryService _service;

        public HomeController(ILibraryService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            _service.DoSomething();
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