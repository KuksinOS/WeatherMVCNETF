using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeatherMVCNETF.Controllers
{
    public class WeatherController : Controller
    {
        public ActionResult Index()
        {
            return PartialView();
        }


        // GET: Weather
        public ActionResult _Index()
        {
            ViewBag.Message = "Weather";
            return PartialView();
        }
    }
}