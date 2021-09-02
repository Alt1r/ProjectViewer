using ProjectViewer.Models.HierarchyStructure.Interfaces;

namespace ProjectViewer.View.EventArgs
{
    public class CurrentSelectedChangedArgs : System.EventArgs
    {
        public IHasChildren<IHasChildren> Node;

        public CurrentSelectedChangedArgs(IHasChildren<IHasChildren> node)
        {
            Node = node;
        }
    }
}