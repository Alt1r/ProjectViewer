using System.Collections.Generic;
using System.Linq;
using ProjectViewer.Models.Interfaces;
using ProjectViewer.Nodes.Interfaces;

namespace ProjectViewer.Nodes
{
    public class BaseNode<T>: INode<T>
    {
        private INode _parent;
        private HashSet<INode> _children;
        public bool HasChildren { get; set; }
        public bool HasParent { get; set; }
        public INode Parent {
            get => _parent;
            set
            {
                HasChildren = (value is null);
                _parent = value;
            }
        }

        public HashSet<INode> Children
        {
            get => _children;
            set
            {
                value = value ?? new HashSet<INode>();
                HasChildren = value.Any();
                _children = value;
            }
        }
        public T Item { get; set; }

        protected BaseNode(INode parent = null, HashSet<INode> children = null)
        {
            Parent = parent;
            Children = children;
        }

        public void AddChildren(INode node)
        {
            if (Children.Contains(node)) return;
            Children.Add(node);
        }
        
        public void Remove()
        {
            Parent.RemoveChild(this);
        }

        public void RemoveChild(INode node)
        {
            node.RemoveAllChild();
            Children.Remove(node);
        }

        public void RemoveAllChild()
        {
            foreach (var child in Children)
            {
                child.RemoveAllChild();
            }
            Children.Clear();
        }
    }
}