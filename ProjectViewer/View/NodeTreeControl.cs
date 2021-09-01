using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Windows.Forms;
using ProjectViewer.Nodes.Interfaces;

namespace ProjectViewer.View
{
    public partial class NodeTreeControl : UserControl
    {
        private INode Root;
        
        public NodeTreeControl()
        {
            InitializeComponent();
        }
        
        public NodeTreeControl(INode root) : base()
        {
            ReloadData(root);
        }

        public void CreateTestData()
        {
            var flvl = 5;
            var slvl = 10;
            var tlvl = 15;
            var flvlNode = CreateTestNode("flvl node:", flvl);
            
            foreach (var node in flvlNode)
            {
                var newNodes = CreateTestNode("slvlNode:", slvl);
                foreach(var newNode in newNodes) node.Nodes.Add(newNode);
            }

            for (int i = 0; i < flvl; i++)
            {
                var fNode = new TreeNode("1lvlNode" + i);
                _tvData.Nodes.Add(fNode);
                for (int j = 0; j < slvl; j++)
                {
                    var sNode = new TreeNode("2lvlNode" + j);
                    fNode.Nodes.Add(sNode);
                    for (int k= 0; k < tlvl; k++)
                    {
                        var tNode = new TreeNode("3lvlNode" + k);
                        sNode.Nodes.Add(tNode);
                    }
                }
            }

            for (int i = 0; i < _tvData.Nodes.Count - 1; i++)
            {
                _tvData.Nodes[i].Text += $" ID:{_tvData.Nodes[i].Index}";
            }
        }

        public void CreateChildTestNodes(TreeNode[] parentNodes, string name, int count)
        {
            if (parentNodes == null) throw new ArgumentNullException(nameof(parentNodes));
            foreach (var node in parentNodes)
            {
                var newNodes = CreateTestNode(name, count);
                foreach(var newNode in newNodes) node.Nodes.Add(newNode);
            }
        }

        private List<TreeNode> CreateTestNode(string name, int count)
        {
            var nodes = new List<TreeNode>(count);
            for (var i = 0; i < count; i++)
            {
                var treeNode = new TreeNode(name);
                nodes.Add(treeNode);
            }

            return nodes;
        }

        private void ReloadData(INode root)
        {
            Root = root;
            var treeNode = CreateTreeNode(root);
            _tvData.Nodes.Clear();
            _tvData.Nodes.Add(treeNode);
        }

        private TreeNode CreateTreeNode(INode node)
        {
            var treeNode = new TreeNode(node.GetName());
            node.Id = treeNode.Index;
            foreach (var childNode in node.Children)
            {
                treeNode.Nodes.Add(CreateTreeNode(childNode));
            }
            
            return treeNode;
        }
        
    }
}