using System;
using System.Runtime.Serialization;

namespace Eolande.ZTree.Domain
{
    [Serializable]
    [DataContract]
    public partial class ZTreeDomain
    {
        [DataMember]
        public virtual int id { get; set; }
        [DataMember]
        public virtual int pId { get; set; }
        [DataMember]
        public virtual string name { get; set; }
        [DataMember]
        public virtual bool open { get; set; }
        [DataMember]
        public virtual string Info { get; set; }

        public virtual TreeModel CopyToTreeModel()
        {
            return new TreeModel() { id = this.id, text = this.name, expanded = this.open };
        }

    }
}
