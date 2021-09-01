using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using ProjectViewer.Models.Interfaces;
using ProjectViewer.Nodes.Interfaces;

namespace ProjectViewer.Nodes
{
    public class ObjectNode : BaseNode, INode<IObjectModel>
    {
        public IObjectModel Item { get; set; }

        public ObjectNode(INode parent, IObjectModel item, HashSet<INode> children = null) 
            : base (parent, children)
        {
            Item = item;
        }

        public override string GetName()
        {
            return Item.Name;
        }
    }
}