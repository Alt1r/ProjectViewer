using ProjectViewer.Models.HierarchyStructure.Interfaces;

namespace ProjectViewer.View.EventArgs
{
    public class CurrentSelectedChangedArgs : System.EventArgs
    {
        public INode Node;

        public CurrentSelectedChangedArgs(INode node)
        {
            Node = node;
        }
    }
}