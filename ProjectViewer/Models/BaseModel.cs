using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProjectViewer.Models.HierarchyStructure;
using ProjectViewer.Models.HierarchyStructure.Interfaces;
using ProjectViewer.Models.Interfaces;

namespace ProjectViewer.Models
{
    public class BaseModel : BaseNode, IBaseModel
    {
        [DisplayName("Дата создания")]
        [Category("Временные метки")]
        [Description("Дата создания UTC")]
        public DateTime CreationTimestamp { get; }
        
        [DisplayName("Дата изменения")]
        [Category("Временные метки")]
        [Description("Дата последнего изменения UTC")]
        public DateTime LastModifyTimestamp { get; private set; }
        
        protected BaseModel(INode parent = null, bool childless = false) : base(parent, childless)
        {
            LastModifyTimestamp = CreationTimestamp = DateTime.UtcNow;
        }

        protected override void ChildOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            LastModifyTimestamp = DateTime.UtcNow;
            base.NotifyPropertyChanged(nameof(LastModifyTimestamp));
        }

        protected override void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            LastModifyTimestamp = DateTime.UtcNow;
            base.NotifyPropertyChanged(propertyName);
        }
    }
}