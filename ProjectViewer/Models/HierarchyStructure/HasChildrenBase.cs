using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ProjectViewer.Models.HierarchyStructure.Interfaces;

namespace ProjectViewer.Models.HierarchyStructure
{
    public class BaseHasChildren<T> : IHasChildren<T> where T : IHasChildren
    {
        private IHasChildren<T> _parent;
        [Browsable(false)]
        public HashSet<IHasChildren<T>> Children { get; set; }

        [Browsable(false)]
        public IHasChildren<T> Parent
        {
            get => _parent;
            set
            {
                _parent = value;
                if (value is null)
                {
                    IsRoot = false;
                    Depth = 0;
                }
                else
                {
                    _parent.AddChildren(this);
                    Depth = _parent.Depth + 1;
                    IsRoot = true;
                }
            }
        }
        [Browsable(false)]
        public bool Childless { get; set; }
        [Browsable(false)]
        public int Depth { get; private set; }
        [Browsable(false)]
        public bool IsRoot { get; private set; }
        [Browsable(false)]
        public bool HasChilds { get; private set; }

        protected BaseHasChildren(IHasChildren<T> parent = null, bool childless = false)
        { 
            Parent = parent;
            Children = new HashSet<IHasChildren<T>>();
            Childless = childless;
        }
        
        public void AddChildren(IHasChildren<T> child)
        {
            if (Childless) throw new Exception($"Error on AddChildren: This node should be Childless");
            if (Children.Contains(child)) return;
            Children.Add(child);
        }
        
        public void Remove()
        {
            Parent?.RemoveChild(this);
            RemoveAllChild();
        }

        public void RemoveChild(IHasChildren<T> child)
        {
            child.RemoveAllChild();
            Children.Remove(child);
            HasChilds = Children.Any();
        }

        public void RemoveAllChild()
        {
            foreach(var child in Children)
            {
                child.RemoveAllChild();
            }
            Children.Clear();
            HasChilds = false;
        }
    }
}