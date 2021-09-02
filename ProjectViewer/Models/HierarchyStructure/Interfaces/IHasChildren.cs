using System.Collections.Generic;

namespace ProjectViewer.Models.HierarchyStructure.Interfaces
{
    public interface IHasChildren<T> : IHasChildren
    {
        IHasChildren<T> Parent { get; set; }
        IReadOnlyCollection<IHasChildren<T>> Children { get; }
        
        void AddChildren(IHasChildren<T> child);
        void RemoveChild(IHasChildren<T> child);
    }
    
    public interface IHasChildren
    {
        int Depth { get; }
        bool Childless { get; set; }
        bool IsRoot { get; }
        bool HasChilds { get; }
        void Remove();
    }
}