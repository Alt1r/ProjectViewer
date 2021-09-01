using System.Collections.Generic;
using ProjectViewer.Models.Interfaces;
using ProjectViewer.Nodes.Interfaces;

namespace ProjectViewer.Nodes
{
    public class BaseNode: INode
    {
        public INode Parent { get; set; }
        public HashSet<INode> Children { get; set; }
        public int Id { get; set; } = 0;

        protected BaseNode(INode parent = null, HashSet<INode> children = null)
        {
            Parent = parent;
            Children = children ?? new HashSet<INode>();
        }

        public virtual string GetName()
        {
            return "BaseNodeName";
        }

        public bool IsRoot()
        {
            return Parent is null;
        }
    }
}