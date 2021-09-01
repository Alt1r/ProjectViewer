using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProjectViewer.Models.EventArgs;
using ProjectViewer.Models.Interfaces;
using ProjectViewer.Nodes;
using ProjectViewer.Nodes.Interfaces;

namespace ProjectViewer.Models
{
    public class ObjectModel : HasChildrenBase<IObjectModel>, IObjectModel
    {
        [DisplayName("Код")]
        [Category("Основное")]
        [Description("Код объекта типа string")]
        public string ObjectId { get; set; }

        private string _name;

        [DisplayName("Название")]
        [Category("Основное")]
        [Description("Название объекта типа string")]
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                InvokeNameChanged(_name);
            }
        }

        public ObjectModel(IHasChildren<IObjectModel> parent, bool childless, string id, string name)
            : base(parent, childless)
        {
            ObjectId = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}