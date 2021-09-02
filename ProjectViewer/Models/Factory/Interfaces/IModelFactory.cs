using ProjectViewer.Models.HierarchyStructure.Interfaces;
using ProjectViewer.Models.Interfaces;

namespace ProjectViewer.Models.Factory.Interfaces
{
    public interface IModelFactory
    {
        IObjectModel CreateObjectModel(IHasChildren<IObjectModel> parent);
        IProjectModel CreateProjectModel();
    }
}