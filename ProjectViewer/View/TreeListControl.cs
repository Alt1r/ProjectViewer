using System.Windows.Forms;
using ProjectViewer.Nodes.Interfaces;

namespace ProjectViewer.View
{
    public partial class TreeListControl : UserControl
    {
        private INode Root;
        
        public TreeListControl()
        {
            InitializeComponent();
        }
        
        public TreeListControl(INode root) : base()
        {
            ReloadData(root);
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

            foreach (var childNode in node.Children)
            {
                treeNode.Nodes.Add(CreateTreeNode(childNode));
            }
            
            return treeNode;
        }
        
    }
}