using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml;
using ProjectViewer.Models.HierarchyStructure;
using ProjectViewer.Models.HierarchyStructure.Interfaces;

namespace ProjectViewer.Models.Interfaces
{
    public interface IBaseModel<T> : IHasChildren<T>, INotifyPropertyChanged, ITimestampModel where T : IHasChildren
    {
        
    }
}