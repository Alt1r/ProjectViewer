using ProjectViewer.Models.Interfaces;
using ProjectViewer.Nodes.Interfaces;

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