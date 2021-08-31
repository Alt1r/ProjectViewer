using ProjectViewer.Models.Interfaces;

namespace ProjectViewer.Models
{
    public class ProjectModel : IProjectModel
    {
        public string ProjectId { get; set; }
        public string Name { get; set; }

        public ProjectModel(string id, string name)
        {
            ProjectId = id;
            Name = name;
        }
    }
}