using System.Collections.Generic;

namespace ProjectViewer.Nodes.Interfaces
{
    public interface INode
    {
        INode Parent { get; set; }
        IEnumerable<INode> Children { get; set; }
        
        string GetName();
        bool IsRoot();
    }
}