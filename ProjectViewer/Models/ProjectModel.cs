using System;
using System.ComponentModel;
using ProjectViewer.Models.Interfaces;

namespace ProjectViewer.Models
{
    public class ProjectModel : BaseModel, IProjectModel
    {
        private string _porjectId;
        [DisplayName("Шифр")]
        [Category("Основное")]
        [Description("Шифр проекта типа string")]
        public string ProjectId 
        { 
            get => _porjectId;
            set
            {
                _porjectId = value ?? throw new Exception("ProjectModel.ProjectId can't be null");
                NotifyPropertyChanged();
            } 
        }

        private string _name;
        [DisplayName("Название")]
        [Category("Основное")]
        [Description("Название проекта типа string")]
        public string Name
        {
            get => _name;
            set
            {
                _name = value ?? throw new Exception("ProjectModel.Name can't be null");
                NotifyPropertyChanged();
            }
        }

        public ProjectModel(string id, string name) 
            : base()
        {
            ProjectId = id ?? throw new Exception("ProjectModel.ProjectId can't be null");
            Name = name;
        }
        
        public override string ToString()
        {
            return Name;
        }
    }
}