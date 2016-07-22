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
        public virtual int Id { get; set; }
        public virtual int PId { get; set; }
        public virtual string Name { get; set; }
        
    }
}
