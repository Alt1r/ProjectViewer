using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProjectViewer.Models.EventArgs;
using ProjectViewer.Models.Interfaces;
using ProjectViewer.Nodes;
using ProjectViewer.Nodes.Interfaces;

namespace ProjectViewer.Models
{
    public class ProjectModel : HasChildrenBase<IObjectModel>, IProjectModel
    {
        [DisplayName("Шифр")]
        [Category("Основное")]
        [Description("Шифр проекта типа string")]
        public string ProjectId { get; set; }

        private string _name;
        [DisplayName("Название")]
        [Category("Основное")]
        [Description("Название проекта типа string")]
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                InvokeNameChanged(_name);
            }
        }

        public ProjectModel(string id, string name) 
            : base()
        {
            ProjectId = id;
            Name = name;
        }
        
        public override string ToString()
        {
            return Name;
        }
    }
}