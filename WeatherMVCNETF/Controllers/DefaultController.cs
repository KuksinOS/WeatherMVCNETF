using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeatherMVCNETF.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ViewBag.Message = "Your application main page.";
            return PartialView();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return PartialView();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return PartialView();
        }



    }
}