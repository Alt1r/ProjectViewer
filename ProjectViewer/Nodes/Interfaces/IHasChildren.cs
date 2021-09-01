using System;
using System.Collections.Generic;
using ProjectViewer.Models.EventArgs;

namespace ProjectViewer.Nodes.Interfaces
{
    public interface IHasChildren<T> : IHasChildren
    {
        IHasChildren<T> Parent { get; set; }
        HashSet<IHasChildren<T>> Children { get; set; }
        
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
        void RemoveAllChild();
        event EventHandler<NameChangedEventArgs> NameChanged;
    }
}