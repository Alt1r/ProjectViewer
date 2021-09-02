using System.ComponentModel;
using ProjectViewer.Models.HierarchyStructure.Interfaces;

namespace ProjectViewer.Models.Interfaces
{
    public interface IProjectModel : IBaseModel<IObjectModel>
    {
        string ProjectId { get; set; }
        string Name { get; set; }
    }
}