using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDDPMIRas.Models;
using IDDPMIRas.Sample;

namespace IDDPMIRas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel();
            hvm.Eventos = CalendarioSampleData.getEventos();
            return View(hvm);
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

        public ActionResult _Swiper()
        {
            return View("~/Views/Home/Sections/_Swiper.cshtml");
        }
        

    }
}