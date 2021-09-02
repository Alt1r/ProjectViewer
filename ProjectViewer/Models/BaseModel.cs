using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProjectViewer.Models.HierarchyStructure;
using ProjectViewer.Models.HierarchyStructure.Interfaces;
using ProjectViewer.Models.Interfaces;

namespace ProjectViewer.Models
{
    public class BaseModel : BaseHasChildren<INode>, IBaseModel
    {
        [DisplayName("Дата создания")]
        [Category("Временные метки")]
        [Description("Дата создания UTC")]
        public DateTime CreationTimestamp { get; private set; }
        
        [DisplayName("Дата изменения")]
        [Category("Временные метки")]
        [Description("Дата последнего изменения UTC")]
        public DateTime LastModifyTimestamp { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;

        protected BaseModel(INode parent = null, bool childless = false) : base(parent, childless)
        {
            LastModifyTimestamp = CreationTimestamp = DateTime.UtcNow;
        }

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            LastModifyTimestamp = DateTime.UtcNow;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}