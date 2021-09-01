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

namespace ProjectViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _propertyGridControl.SetData(new ProjectModel("proj1", "ASU"));
            _nodeTreeControl.CreateTestData();
        }
    }
}