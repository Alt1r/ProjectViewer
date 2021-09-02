using System;
using System.ComponentModel;
using ProjectViewer.Models.HierarchyStructure.Interfaces;

namespace ProjectViewer.Models.Interfaces
{
    public interface IObjectModel : IBaseModel<IObjectModel>
    {
        string ObjectId { get; set; }
        string Name { get; set; }
    }
}