using System.Collections.Generic;
using ProjectViewer.Models.Interfaces;
using ProjectViewer.Nodes.Interfaces;

namespace ProjectViewer.Nodes
{
    public class BaseNode: INode
    {
        public INode Parent { get; set; }
        public IEnumerable<INode> Children { get; set; }

        protected BaseNode(INode parent, IEnumerable<INode> children = null)
        {
            Parent = parent;
            Children = children ?? new List<INode>();
        }

        public virtual string GetName()
        {
            return "BaseNodeName";
        }

        public bool IsRoot()
        {
            return false;
        }
    }
}