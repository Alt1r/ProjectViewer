namespace ProjectViewer.Models.Interfaces
{
    public interface IObjectModel : IBaseModel
    {
        string ObjectId { get; set; }
        string Name { get; set; }
    }
}