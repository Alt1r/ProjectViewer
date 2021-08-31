using System.ComponentModel;

namespace ProjectViewer.View
{
    partial class TreeListControl
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
            this._tvData = new System.Windows.Forms.TreeView();
            this._lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _tvData
            // 
            this._tvData.Location = new System.Drawing.Point(3, 51);
            this._tvData.Name = "_tvData";
            this._tvData.Size = new System.Drawing.Size(211, 395);
            this._tvData.TabIndex = 0;
            // 
            // _lbName
            // 
            this._lbName.BackColor = System.Drawing.SystemColors.Control;
            this._lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lbName.Location = new System.Drawing.Point(11, 9);
            this._lbName.Name = "_lbName";
            this._lbName.Size = new System.Drawing.Size(179, 27);
            this._lbName.TabIndex = 1;
            this._lbName.Text = "Дерево проектов";
            // 
            // TreeListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this._lbName);
            this.Controls.Add(this._tvData);
            this.Name = "TreeListControl";
            this.Size = new System.Drawing.Size(217, 449);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TreeView _tvData;
        private System.Windows.Forms.Label _lbName;

        private System.Windows.Forms.TreeView treeView1;

        #endregion
    }
}