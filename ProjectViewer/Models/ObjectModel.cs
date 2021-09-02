using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProjectViewer.Models.HierarchyStructure.Interfaces;
using ProjectViewer.Models.Interfaces;

namespace ProjectViewer.Models
{
    public class ObjectModel : BaseModel, IObjectModel
    {
        private string _objectId;
        [DisplayName("Код")]
        [Category("Основное")]
        [Description("Код объекта типа string")]
        public string ObjectId 
        { 
            get => _objectId;
            set
            {
                _objectId = value ?? throw new Exception("ObjectModel.ObjectId can't be null");
                NotifyPropertyChanged();
            } 
        }

        private string _name;

        [DisplayName("Название")]
        [Category("Основное")]
        [Description("Название объекта типа string")]
        public string Name
        {
            get => _name;
            set
            {
                _name = value ?? throw new Exception("ObjectModel.Name can't be null");
                NotifyPropertyChanged();
            }
        }

        public ObjectModel(INode parent, bool childless, string id, string name)
            : base(parent, childless)
        {
            ObjectId = id ?? throw new Exception("ObjectModel.ObjectId can't be null");
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}