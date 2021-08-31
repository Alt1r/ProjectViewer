using ProjectViewer.Models.Interfaces;

namespace ProjectViewer.Models
{
    public class ObjectModel : IObjectModel
    {
        public string ObjectId { get; set; }
        public string Name { get; set; }

        public ObjectModel(string id, string name)
        {
            ObjectId = id;
            Name = name;
        }
    }
}