using ProjectViewer.Models.Interfaces;

namespace ProjectViewer.Models.Factory.Interfaces
{
    public interface IModelFactory
    {
        IObjectModel CreateObjectModel(IBaseModel parent);
        IProjectModel CreateProjectModel();
    }
}