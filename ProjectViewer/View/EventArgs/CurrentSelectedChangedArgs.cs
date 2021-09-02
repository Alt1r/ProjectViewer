using ProjectViewer.Models.HierarchyStructure.Interfaces;
using ProjectViewer.Models.Interfaces;

namespace ProjectViewer.View.EventArgs
{
    public class CurrentSelectedChangedArgs : System.EventArgs
    {
        public IHasChildren<IObjectModel> Node;

        public CurrentSelectedChangedArgs(IHasChildren<IObjectModel> node)
        {
            Node = node;
        }
    }
}