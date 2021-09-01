using ProjectViewer.Nodes.Interfaces;

namespace ProjectViewer.Models.Interfaces
{
    public interface IProjectModel : IHasChildren<IObjectModel>, INameChangedNotificator
    {
        string ProjectId { get; set; }
        string Name { get; set; }
    }
}