using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ProjectViewer.Models;
using ProjectViewer.Models.Interfaces;
using ProjectViewer.Nodes.Interfaces;

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
            
            var modelHashSet = new HashSet<IHasChildren<IObjectModel>>(){
                projModel
            };
            
            _projectViewControl.ReloadData(modelHashSet);
            //_projectViewControl.ReloadData(projModel);
            //_propertyGridControl.SetData(new ProjectModel("proj1", "ASU"));
            //_nodeTreeControl.CreateTestData();
        }
    }
}