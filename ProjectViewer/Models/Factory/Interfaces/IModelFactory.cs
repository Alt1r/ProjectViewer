using ProjectViewer.Models.Interfaces;
using ProjectViewer.Nodes.Interfaces;

namespace ProjectViewer.Models.Factory.Interfaces
{
    public interface IModelFactory
    {
        IObjectModel CreateObjectModel(IHasChildren<IObjectModel> parent);
        IProjectModel CreateProjectModel();
    }
}