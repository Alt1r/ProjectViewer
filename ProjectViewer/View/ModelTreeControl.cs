using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Windows.Forms;
using ProjectViewer.Models;
using ProjectViewer.Models.EventArgs;
using ProjectViewer.Models.Factory;
using ProjectViewer.Models.Factory.Interfaces;
using ProjectViewer.Models.Interfaces;
using ProjectViewer.Nodes.Interfaces;
using ProjectViewer.View.EventArgs;

namespace ProjectViewer.View
{
    public partial class ModelTreeControl : UserControl
    {
        private IHasChildren<IObjectModel> _currentSelected;
        private readonly Dictionary<TreeNode, IHasChildren<IObjectModel>> _treeModelDictionary;
        private readonly Dictionary<IHasChildren<IObjectModel>, TreeNode> _modelTreeDictionary;
        public event EventHandler<CurrentSelectedChangedArgs> CurrentSelectedChanged;
        private IModelFactory _modelFactory;

        public IModelFactory ModelFactory
        {
            private get => _modelFactory;
            set
            {
                _modelFactory = value;
                _btnRemove.Enabled = _btnAddObject.Enabled = _btnAddProject.Enabled = true;
                UpdateButtonEnable();
            }
        }

        private IHasChildren<IObjectModel> CurrentSelected
        {
            get => _currentSelected;
            set
            {
                _currentSelected = value;
                CurrentSelectedChanged?.Invoke(this, new CurrentSelectedChangedArgs(value));
                _btnAddObject.Text = $"+Объект {(_currentSelected?.Depth ?? 0) + 1}-го";
                UpdateButtonEnable();
            }
        }

        public ModelTreeControl()
        {
            InitializeComponent();
            
            _treeModelDictionary = new Dictionary<TreeNode, IHasChildren<IObjectModel>>();
            _modelTreeDictionary = new Dictionary<IHasChildren<IObjectModel>, TreeNode>();
            
            Subscribe();
            _btnRemove.Enabled = _btnAddObject.Enabled = _btnAddProject.Enabled = false;
            
            ModelFactory = new DefaultModelFactory();
        }

        public void UpdateSelectedNodeText(string text)
        {
            _tvData.SelectedNode.Text = text;
        }

        public void ReloadData(HashSet<IHasChildren<IObjectModel>> nodes)
        {
            ClearTree();
            foreach (var node in nodes)
            {
                CreateTreeNode(node);
            }
        }

        public void ReloadData(IHasChildren<IObjectModel> node)
        {
            ClearTree();
            CreateTreeNode(node);
        }

        private void UpdateButtonEnable()
        {
            _btnRemove.Enabled = (!(CurrentSelected is null));
            _btnAddObject.Enabled = !_currentSelected?.Childless ?? false;
        }

        private void ClearTree()
        {
            _tvData.Nodes.Clear();
            _treeModelDictionary.Clear();
            CurrentSelected = null;
        }

        private TreeNode CreateTreeNode(IHasChildren<IObjectModel> model, TreeNode parentTreeNode = null)
        {
            var treeNode = new TreeNode(model.ToString());
            if (parentTreeNode is null) _tvData.Nodes.Add(treeNode);
            else parentTreeNode.Nodes.Add(treeNode);
            _treeModelDictionary.Add(treeNode, model);
            _modelTreeDictionary.Add(model, treeNode);
            model.NameChanged += ModelOnNameChanged;
            foreach (var childTreeNode in model.Children)
            {
                CreateTreeNode(childTreeNode, treeNode);
            }

            CurrentSelected = model;
            return treeNode;
        }

        private void DeleteModel(TreeNode treeNode)
        {
            var model = _treeModelDictionary[treeNode];
            DeleteModelFromControl(model, treeNode);
        }

        private void DeleteModel(IHasChildren<IObjectModel> model)
        {
            var treeNode = _modelTreeDictionary[model];
            DeleteModelFromControl(model, treeNode);
        }

        private void DeleteModelFromControl(IHasChildren<IObjectModel> model, TreeNode treeNode)
        {
            model.NameChanged -= ModelOnNameChanged;
            _modelTreeDictionary.Remove(model);
            _treeModelDictionary.Remove(treeNode);
            model.Remove();
            treeNode.Remove();
        }

        private void AddSelectionToNode(TreeNode node)
        {
            _tvData.Select();
            _tvData.SelectedNode = node;
            CurrentSelected = CurrentSelected = _tvData.SelectedNode is null ? null : _treeModelDictionary[_tvData.SelectedNode];
        }

#region EventHandlers
        private void Subscribe()
        {
            this.Disposed += OnDisposed;
            _tvData.AfterSelect += TvDataOnAfterSelect;
        }

        private void Unsubscribe()
        {
            this.Disposed -= OnDisposed;
            _tvData.AfterSelect -= TvDataOnAfterSelect; 
        }
        
        private void ModelOnNameChanged(object sender, NameChangedEventArgs e)
        {
            var model = sender as IHasChildren<IObjectModel>;
            if (model is null) return;
            _modelTreeDictionary[model].Text = e.Name;
        }
        
        private void TvDataOnAfterSelect(object sender, TreeViewEventArgs e)
        {
            var treeNode = e.Node;
            CurrentSelected = _treeModelDictionary.ContainsKey(treeNode) 
                ? _treeModelDictionary[treeNode] : null;
        }

        private void OnDisposed(object sender, System.EventArgs e)
        {
            Unsubscribe();
        }     
        
        private void _btnAddProject_Click(object sender, System.EventArgs e)
        {
            var newNode = CreateTreeNode(ModelFactory.CreateProjectModel());
            AddSelectionToNode(newNode);
        }

        private void _btnAddObject_Click(object sender, System.EventArgs e)
        {
            var newNode = CreateTreeNode(ModelFactory.CreateObjectModel(_currentSelected), _tvData.SelectedNode);
            AddSelectionToNode(newNode);
        }

        private void _btnRemove_Click(object sender, System.EventArgs e)
        {
            if (CurrentSelected is null) return;
            DeleteModel(CurrentSelected);
            UpdateButtonEnable();
            AddSelectionToNode(_tvData.SelectedNode);
        }
#endregion
    }
}