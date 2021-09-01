using System.ComponentModel;
using ProjectViewer.Models.Interfaces;

namespace ProjectViewer.Models
{
    public class ObjectModel : IObjectModel
    {
        [DisplayName("Код")]
        [Category("Основное")]
        [Description("Код объекта типа string")]
        public string ObjectId { get; set; }
        
        [DisplayName("Название")]
        [Category("Основное")]
        [Description("Название объекта типа string")]
        public string Name { get; set; }

        public ObjectModel(string id, string name)
        {
            ObjectId = id;
            Name = name;
        }
    }
}