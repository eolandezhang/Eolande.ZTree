using Eolande.ZTree.Domain;
using Newtonsoft.Json;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace Eolande.ZTree.Web.Controllers
{
    public class ZTreeController : ApiController
    {
        public string Get()
        {
            var nhConfig = new Configuration().Configure();
            var sessionFactory = nhConfig.BuildSessionFactory();

            using (var session = sessionFactory.OpenSession())
            {

                var list = session.QueryOver<ZTreeDomain>()
 .List();
                int i = 0;
                list.ToList().ForEach(x => { x.Info = i.ToString();i++; });
                var json = JsonConvert.SerializeObject(list);
               
                return json;
            }

        }
    }
}
