﻿using System.Collections.Generic;
using ProjectViewer.Models.Interfaces;
using ProjectViewer.Nodes.Interfaces;

namespace ProjectViewer.Nodes
{
    public class ProjectNode : BaseNode, INode<IProjectModel>
    {
        public IProjectModel Item { get; set; }

        public ProjectNode(int id, INode parent, IProjectModel item, HashSet<INode> children = null) 
            : base (parent, children)
        {
            Item = item;
        }

        public override string GetName()
        {
            return Item.Name;
        }
    }
}