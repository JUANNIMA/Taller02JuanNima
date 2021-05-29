using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Taller02.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return RedirectToAction("index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [ActionName ("Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Prueba1()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Prueba2()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [ActionName ("Hora")]
        public string HoraActual()
        {
            return CadenaHora();
        }

        [NonAction]
        public string CadenaHora()
        {
            return "Son las " + DateTime.Now.ToString("T");
        }
    }
}