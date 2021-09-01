using System.ComponentModel;
using ProjectViewer.Models.Interfaces;

namespace ProjectViewer.Models
{
    public class ProjectModel : IProjectModel
    {
        [DisplayName("Шифр")]
        [Category("Основное")]
        [Description("Шифр проекта типа string")]
        public string ProjectId { get; set; }
        
        [DisplayName("Название")]
        [Category("Основное")]
        [Description("Название проекта типа string")]
        public string Name { get; set; }

        public ProjectModel(string id, string name)
        {
            ProjectId = id;
            Name = name;
        }
    }
}