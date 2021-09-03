using System.Collections.Generic;
using System.ComponentModel;

namespace ProjectViewer.Models.HierarchyStructure.Interfaces
{
    public interface INode : INotifyPropertyChanged

    {
    INode Parent { get; set; }
    IReadOnlyCollection<INode> Children { get; }

    void AddChildren(INode child);
    void RemoveChild(INode child);
    int Depth { get; }
    bool Childless { get; }
    bool IsRoot { get; }
    bool HasChilds { get; }
    void Remove();
    }
}