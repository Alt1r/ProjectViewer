using System.Collections.Generic;
using System.Windows.Forms;
using ProjectViewer.Models.Interfaces;
using ProjectViewer.Nodes;
using ProjectViewer.Nodes.Interfaces;
using ProjectViewer.View.EventArgs;

namespace ProjectViewer.View
{
    public partial class ModelViewControl : UserControl
    {
        public ModelViewControl()
        {
            InitializeComponent();
            Subscribe();
        }

        public void ReloadData(IHasChildren<IObjectModel> data)
        {
            _nodeTreeControl.ReloadData(data);
        }
        
        public void ReloadData(HashSet<IHasChildren<IObjectModel>> data)
        {
            _nodeTreeControl.ReloadData(data);
        }
        
#region EventHandlers
        private void Subscribe()
        {
            this.Disposed += OnDisposed;
            _nodeTreeControl.CurrentSelectedChanged += NodeTreeControlOnCurrentSelectedChanged;
        }

        private void Unsubscribe()
        {
            this.Disposed -= OnDisposed;
            _nodeTreeControl.CurrentSelectedChanged += NodeTreeControlOnCurrentSelectedChanged;
        }

        private void NodeTreeControlOnCurrentSelectedChanged(object sender, CurrentSelectedChangedArgs e)
        {
            _propertyGridControl.SetData(e.Node);
        }

        private void OnDisposed(object sender, System.EventArgs e)
        {
            Unsubscribe();
        }
#endregion
    }
}