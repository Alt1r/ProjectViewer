using System.Collections.Generic;

namespace ProjectViewer.Models.HierarchyStructure.Interfaces
{
    public interface INode
    {
        INode Parent { get; set; }
        IReadOnlyCollection<INode> Children { get; }
        
        void AddChildren(INode child);
        void RemoveChild(INode child);
        int Depth { get; }
        bool Childless { get; set; }
        bool IsRoot { get; }
        bool HasChilds { get; }
        void Remove();
    }
}