using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ProjectViewer.Models.HierarchyStructure.Interfaces;

namespace ProjectViewer.Models.HierarchyStructure
{
    public abstract class BaseNode : INode 
    {
        private readonly HashSet<INode> _children = new HashSet<INode>();
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
        public event PropertyChangedEventHandler PropertyChanged;

        protected BaseNode(INode parent = null, bool childless = false)
        { 
            Parent = parent;
            Childless = childless;
        }
        
        public void AddChildren(INode child)
        {
            if (Childless) throw new Exception($"Error on AddChildren: This node should be Childless");
            if (Children.Contains(child)) return;
            
            child.PropertyChanged += ChildOnPropertyChanged;
            _children.Add(child);
        }

        protected abstract void ChildOnPropertyChanged(object sender, PropertyChangedEventArgs e);

        public void Remove()
        {
            Parent?.RemoveChild(this);
            foreach (var child in _children)
            {
                child.PropertyChanged -= ChildOnPropertyChanged;
            }
            _children.Clear();
        }

        public void RemoveChild(INode child)
        {
            child.PropertyChanged -= ChildOnPropertyChanged;
            _children.Remove(child);
        }
        
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}