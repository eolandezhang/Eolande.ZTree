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
                //var json = JsonConvert.SerializeObject(list);
                StringBuilder psb = new StringBuilder();
                string cate;
                foreach (var m in list)
                {
                    psb.Append("{");
                    psb.Append("id");
                    psb.Append(":");
                    psb.Append(m.id);
                    psb.Append(",pId:");
                    psb.Append(m.pId);
                    psb.Append(",name:\"");
                    psb.Append(String.IsNullOrEmpty(m.name) ? "" : m.name);

                    //psb.Append("\",title:\"");
                    //psb.Append(String.IsNullOrEmpty(m.TITLE) ? "" : m.TITLE);
                    //psb.Append("\",url");
                    //psb.Append(":\"");
                    //psb.Append(String.IsNullOrEmpty(m.URL) ? "" : m.URL + "?mid=" + m.ID);
                    psb.Append("\",open");
                    psb.Append(":\"");
                    psb.Append("true");

                    //psb.Append(String.IsNullOrEmpty(m.OPEN) ? "" : m.OPEN);
                    //psb.Append("\",target");
                    //psb.Append(":\"");
                    //psb.Append(String.IsNullOrEmpty(m.TARGET) ? "_self" : m.TARGET);
                    //psb.Append("\",icon");
                    //psb.Append(":\"");
                    //psb.Append(String.IsNullOrEmpty(m.ICON) ? "" : m.ICON);

                    //psb.Append("\",sort");
                    //psb.Append(":\"");
                    //psb.Append(m.SORT);

                    //psb.Append("\",pname");
                    //psb.Append(":\"");
                    //psb.Append(m.PNAME);

                    psb.Append("\"},");
                }


                cate = "[";

                cate += psb.ToString().TrimEnd(',');
                cate += "]";
                return cate;
            }

        }
    }
}
