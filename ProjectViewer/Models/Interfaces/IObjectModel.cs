using ProjectViewer.Nodes.Interfaces;

namespace ProjectViewer.Models.Interfaces
{
    public interface IObjectModel : IHasChildren<IObjectModel>, INameChangedNotificator
    {
        string ObjectId { get; set; }
        string Name { get; set; }
    }
}