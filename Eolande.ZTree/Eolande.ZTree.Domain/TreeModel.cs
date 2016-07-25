using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Eolande.ZTree.Domain
{
    [Serializable]
    [DataContract]
    public class TreeModel
    {
        public TreeModel()
        {
            children = new List<TreeModel>();
        }
        [DataMember]
        public virtual int id { get; set; }
        [DataMember]
        public virtual string text { get; set; }
        [DataMember]
        public virtual bool expanded { get; set; }
        [DataMember]
        public virtual bool leaf { get; set; }
        [DataMember]
        public virtual List<TreeModel> children { get; set; }

        
    }
}
