using System.ComponentModel;
using System.Windows.Forms;
using ProjectViewer.Models.Interfaces;

namespace ProjectViewer.View
{
    public partial class ModelPropertyGridControl : UserControl
    {
        public ModelPropertyGridControl()
        {
            InitializeComponent();
        }
        
        public void SetData<T>(T dataSource)  
        {
            _propertyGrid.SelectedObject = dataSource;
        }

        public void SetData<T>(IBaseModel<T> dataSource) where T : IBaseModel<T>
        {
            var oldModel = _propertyGrid.SelectedObject as IBaseModel<T>;
            if (!(oldModel is null)) 
                oldModel.PropertyChanged -= ModelOnPropertyChanged;
            
            
            if (!(dataSource is null)) 
                dataSource.PropertyChanged += ModelOnPropertyChanged;
            
            _propertyGrid.SelectedObject = dataSource;
        }

        private void ModelOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _propertyGrid.Refresh();
        }
    }
}