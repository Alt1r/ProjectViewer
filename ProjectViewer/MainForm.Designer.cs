namespace ProjectViewer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._nodeTreeControl = new ProjectViewer.View.NodeTreeControl();
            this._propertyGridControl = new ProjectViewer.View.PropertyGridControl();
            this.SuspendLayout();
            // 
            // _nodeTreeControl
            // 
            this._nodeTreeControl.BackColor = System.Drawing.SystemColors.Desktop;
            this._nodeTreeControl.Location = new System.Drawing.Point(1, -4);
            this._nodeTreeControl.Name = "_nodeTreeControl";
            this._nodeTreeControl.Size = new System.Drawing.Size(223, 454);
            this._nodeTreeControl.TabIndex = 0;
            // 
            // _propertyGridControl
            // 
            this._propertyGridControl.BackColor = System.Drawing.SystemColors.Desktop;
            this._propertyGridControl.Location = new System.Drawing.Point(230, 12);
            this._propertyGridControl.Name = "_propertyGridControl";
            this._propertyGridControl.Size = new System.Drawing.Size(309, 334);
            this._propertyGridControl.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._propertyGridControl);
            this.Controls.Add(this._nodeTreeControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private ProjectViewer.View.PropertyGridControl _propertyGridControl;

        private ProjectViewer.View.NodeTreeControl _nodeTreeControl;

        #endregion
    }
}