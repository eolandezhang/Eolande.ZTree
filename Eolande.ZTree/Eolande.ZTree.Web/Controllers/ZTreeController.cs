using Eolande.ZTree.Domain;
using NHibernate.Cfg;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Eolande.ZTree.Web.Controllers
{
    public class ZTreeController : ApiController
    {

        public TreeModel Get()
        {
            var nhConfig = new Configuration().Configure();
            var sessionFactory = nhConfig.BuildSessionFactory();
            TreeModel root = null;

            using (var session = sessionFactory.OpenSession())
            {
                var list = session.QueryOver<ZTreeDomain>().List().ToList();
                var r = list.FirstOrDefault(x => x.pId == -1);
                root = new TreeModel() { text = "." };
               
                if (r != null)
                {
                    var p = r.CopyToTreeModel();
                    root.children.Add(p);
                    var childs = list.Where(x => x.pId == p.id);
                    foreach (var c in childs)
                    {
                        var m = c.CopyToTreeModel();
                        root.children.Add(m);
                        ChildNode(m, list);
                    }
                }
                return root;
            }

        }

        private void ChildNode(TreeModel root, List<ZTreeDomain> list)
        {
            var childs = list.Where(x => x.pId == root.id);
            foreach (var c in childs)
            {
                var n = c.CopyToTreeModel();
                root.children.Add(n);
                ChildNode(n, list.Where(x => x.pId == c.id).ToList());
            }
        }
    }
}
