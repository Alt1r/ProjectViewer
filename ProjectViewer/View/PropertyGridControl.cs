using System.Windows.Forms;
using ProjectViewer.Models.Interfaces;

namespace ProjectViewer.View
{
    public partial class PropertyGridControl : UserControl
    {
        public PropertyGridControl()
        {
            InitializeComponent();
        }

        public void SetData<T>(T dataSource) 
        {
            _propertyGrid.SelectedObject = dataSource;
        }
    }
}