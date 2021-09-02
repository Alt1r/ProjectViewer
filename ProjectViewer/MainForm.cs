using System.Collections.Generic;
using System.Windows.Forms;
using ProjectViewer.Models;
using ProjectViewer.Models.Interfaces;

namespace ProjectViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var projModel = new ProjectModel("proj1", "ASU");
            var firstLvlObject = new ObjectModel(projModel, false, "1lvlObject", "Водокачка");
            var firstLvlObject2 = new ObjectModel(projModel, false, "1lvlObject2", "Водокачка2");
            var secondLvlObject = new ObjectModel(firstLvlObject, true,"2lvlObject", "Труба" );
            var secondLvlObject2 = new ObjectModel(firstLvlObject, true,"2lvlObject2", "Труба2" );
            
            var modelHashSet = new HashSet<IBaseModel>(){
                projModel
            };
            
            _projectViewControl.ReloadData(modelHashSet);
        }
    }
}