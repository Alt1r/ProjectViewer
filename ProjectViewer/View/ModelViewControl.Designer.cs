using System.ComponentModel;

namespace ProjectViewer.View
{
    partial class ModelViewControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._nodeTreeControl = new ProjectViewer.View.ModelTreeControl();
            this._propertyGridControl = new ProjectViewer.View.ModelPropertyGridControl();
            this.SuspendLayout();
            // 
            // _nodeTreeControl
            // 
            this._nodeTreeControl.BackColor = System.Drawing.SystemColors.Desktop;
            this._nodeTreeControl.Location = new System.Drawing.Point(0, 0);
            this._nodeTreeControl.MaximumSize = new System.Drawing.Size(250, 400);
            this._nodeTreeControl.MinimumSize = new System.Drawing.Size(250, 400);
            this._nodeTreeControl.Name = "_nodeTreeControl";
            this._nodeTreeControl.Size = new System.Drawing.Size(250, 400);
            this._nodeTreeControl.TabIndex = 0;
            // 
            // _propertyGridControl
            // 
            this._propertyGridControl.BackColor = System.Drawing.SystemColors.Desktop;
            this._propertyGridControl.Location = new System.Drawing.Point(247, 0);
            this._propertyGridControl.MaximumSize = new System.Drawing.Size(350, 400);
            this._propertyGridControl.MinimumSize = new System.Drawing.Size(350, 400);
            this._propertyGridControl.Name = "_propertyGridControl";
            this._propertyGridControl.Size = new System.Drawing.Size(350, 400);
            this._propertyGridControl.TabIndex = 1;
            // 
            // ProjectViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._propertyGridControl);
            this.Controls.Add(this._nodeTreeControl);
            this.Name = "ModelViewControl";
            this.Size = new System.Drawing.Size(600, 400);
            this.ResumeLayout(false);
        }

        private ProjectViewer.View.ModelTreeControl _nodeTreeControl;
        private ProjectViewer.View.ModelPropertyGridControl _propertyGridControl;

        #endregion
    }
}