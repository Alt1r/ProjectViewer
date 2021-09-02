using System.ComponentModel;
using ProjectViewer.Models.HierarchyStructure.Interfaces;

namespace ProjectViewer.Models.Interfaces
{
    public interface IBaseModel : IHasChildren<IHasChildren>, INotifyPropertyChanged, ITimestampModel
    {
        
    }
}