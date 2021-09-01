using System.Collections.Generic;

namespace ProjectViewer.Nodes.Interfaces
{
    public interface INode
    {
        INode Parent { get; set; }
        HashSet<INode> Children { get; set; }
        int Id { get; set; }
        
        string GetName();
        bool IsRoot();
    }
}