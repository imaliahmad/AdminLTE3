using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThemeUI.Controllers
{
    public class ActionsController : Controller
    {
        // GET: Actions
        public ActionResult RequestReport()
        {
            return View();
        }

        public ActionResult ResolveErrors()
        {
            return View();
        }

        public ActionResult RecalculateErrors()
        {
            return View();
        }
    }
}