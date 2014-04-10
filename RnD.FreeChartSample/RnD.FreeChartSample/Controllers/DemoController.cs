using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RnD.FreeChartSample.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/

        public ActionResult Chart()
        {
            return View();
        }

        public ActionResult Morris()
        {
            return View();
        }

        public ActionResult AMCharts()
        {
            return View();
        }

        public ActionResult Flot()
        {
            return View();
        }

    }
}
