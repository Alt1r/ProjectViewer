namespace ProjectViewer.Models.Interfaces
{
    public interface IProjectModel : IBaseModel
    {
        string ProjectId { get; set; }
        string Name { get; set; }
    }
}