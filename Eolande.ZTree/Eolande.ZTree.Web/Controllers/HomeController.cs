using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eolande.ZTree.Domain;

namespace Eolande.ZTree.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var nhConfig = new Configuration().Configure();
            var sessionFactory = nhConfig.BuildSessionFactory();

            using (var session = sessionFactory.OpenSession()) { 
             
               var result= session.QueryOver<ZTreeDomain>()
.List();
            }
              
            
            return View();
        }
    }
}
