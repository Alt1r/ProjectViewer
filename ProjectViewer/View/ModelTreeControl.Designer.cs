using System.ComponentModel;

namespace ProjectViewer.View
{
    partial class ModelTreeControl
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
            this._btnAddProject = new System.Windows.Forms.Button();
            this._btnRemove = new System.Windows.Forms.Button();
            this._btnAddObject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _tvData
            // 
            this._tvData.Location = new System.Drawing.Point(3, 97);
            this._tvData.Name = "_tvData";
            this._tvData.Size = new System.Drawing.Size(244, 300);
            this._tvData.TabIndex = 0;
            // 
            // _lbName
            // 
            this._lbName.BackColor = System.Drawing.SystemColors.Control;
            this._lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._lbName.Location = new System.Drawing.Point(0, 0);
            this._lbName.Name = "_lbName";
            this._lbName.Size = new System.Drawing.Size(170, 27);
            this._lbName.TabIndex = 1;
            this._lbName.Text = "Дерево проектов";
            // 
            // _btnAddProject
            // 
            this._btnAddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._btnAddProject.Location = new System.Drawing.Point(3, 30);
            this._btnAddProject.Name = "_btnAddProject";
            this._btnAddProject.Size = new System.Drawing.Size(80, 30);
            this._btnAddProject.TabIndex = 2;
            this._btnAddProject.Text = "+ Проект";
            this._btnAddProject.UseVisualStyleBackColor = true;
            this._btnAddProject.Click += new System.EventHandler(this._btnAddProject_Click);
            // 
            // _btnRemove
            // 
            this._btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._btnRemove.Location = new System.Drawing.Point(3, 66);
            this._btnRemove.Name = "_btnRemove";
            this._btnRemove.Size = new System.Drawing.Size(80, 30);
            this._btnRemove.TabIndex = 3;
            this._btnRemove.Text = "Удалить";
            this._btnRemove.UseVisualStyleBackColor = true;
            this._btnRemove.Click += new System.EventHandler(this._btnRemove_Click);
            // 
            // _btnAddObject
            // 
            this._btnAddObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this._btnAddObject.Location = new System.Drawing.Point(90, 30);
            this._btnAddObject.Name = "_btnAddObject";
            this._btnAddObject.Size = new System.Drawing.Size(114, 30);
            this._btnAddObject.TabIndex = 4;
            this._btnAddObject.Text = "+ Объект 1-го уровня";
            this._btnAddObject.UseVisualStyleBackColor = true;
            this._btnAddObject.Click += new System.EventHandler(this._btnAddObject_Click);
            // 
            // NodeTreeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this._btnAddObject);
            this.Controls.Add(this._btnRemove);
            this.Controls.Add(this._btnAddProject);
            this.Controls.Add(this._lbName);
            this.Controls.Add(this._tvData);
            this.MaximumSize = new System.Drawing.Size(250, 400);
            this.MinimumSize = new System.Drawing.Size(250, 400);
            this.Name = "ModelTreeControl";
            this.Size = new System.Drawing.Size(250, 400);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button _btnAddObject;
        private System.Windows.Forms.Button _btnAddProject;
        private System.Windows.Forms.Button _btnRemove;

        private System.Windows.Forms.TreeView _tvData;
        private System.Windows.Forms.Label _lbName;
        #endregion
    }
}