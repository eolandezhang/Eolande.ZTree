using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eolande.ZTree.Domain;
using Newtonsoft.Json;

namespace Eolande.ZTree.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            


            return View();
        }
    }
}
