using System.Collections.Generic;

namespace ProjectViewer.Nodes.Interfaces
{
    public interface INode
    {
        INode Parent { get; set; }
        HashSet<INode> Children { get; set; }
        bool HasParent { get; set; }
        bool HasChildren { get; set; }
        void AddChildren(INode node);
        void Remove();
        void RemoveChild(INode node);
        void RemoveAllChild();
    }
}