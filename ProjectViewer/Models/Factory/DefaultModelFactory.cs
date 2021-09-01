using ProjectViewer.Models.Factory.Interfaces;
using ProjectViewer.Models.Interfaces;
using ProjectViewer.Nodes.Interfaces;

namespace ProjectViewer.Models.Factory
{
    public class DefaultModelFactory : IModelFactory
    {
        public IObjectModel CreateObjectModel(IHasChildren<IObjectModel> parent)
        {
            var childless = parent.Depth == 1;
            return new ObjectModel(parent, childless, "newObjectId", $"Новый Объект {parent.Depth + 1}-го уровня ");
        }

        public IProjectModel CreateProjectModel()
        {
            return new ProjectModel("newObjectId", "Новый проект");
        }
    }
}