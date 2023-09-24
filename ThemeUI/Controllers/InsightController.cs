using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThemeUI.Controllers
{
    public class InsightController : Controller
    {
        // GET: Insight
        public ActionResult BatchHistory()
        {
            return View();
        }
        public ActionResult AuthHist()
        {
            return View();
        }
        public ActionResult PendingAuths()
        {
            return View();
        }
        public ActionResult BusEvents()
        {
            return View();
        }
    }
}