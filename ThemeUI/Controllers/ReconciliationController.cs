using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThemeUI.Controllers
{
    public class ReconciliationController : Controller
    {
        // GET: Reconciliation
        public ActionResult ErrorReport()
        {
            return View();
        }
        public ActionResult ErrorConfiguration()
        {
            return View();
        }
        public ActionResult SuccessReport()
        {
            return View();
        }
    }
}