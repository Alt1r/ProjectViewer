using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ProjectViewer.Models.HierarchyStructure.Interfaces;

namespace ProjectViewer.Models.HierarchyStructure
{
    public class BaseHasChildren<T> : INode where T : INode
    {
        private readonly HashSet<INode> _children;
        [Browsable(false)]
        public IReadOnlyCollection<INode> Children => _children;

        private INode _parent;
        [Browsable(false)]
        public INode Parent
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
        public bool HasChilds => Children.Any();

        protected BaseHasChildren(INode parent = null, bool childless = false)
        { 
            Parent = parent;
            _children = new HashSet<INode>();
            Childless = childless;
        }
        
        public void AddChildren(INode child)
        {
            if (Childless) throw new Exception($"Error on AddChildren: This node should be Childless");
            if (Children.Contains(child)) return;
            
            _children.Add(child);
        }
        
        public void Remove()
        {
            Parent?.RemoveChild(this);
            _children.Clear();
        }

        public void RemoveChild(INode child)
        {
            _children.Remove(child);
        }
    }
}