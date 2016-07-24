using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eolande.ZTree.Domain
{
    [Serializable]
    public partial class ZTreeDomain
    {
        public virtual int id { get; set; }
        public virtual int pId { get; set; }
        public virtual string name { get; set; }
        public virtual bool open { get; set; }
        public virtual string Info { get; set; }
    }
}
