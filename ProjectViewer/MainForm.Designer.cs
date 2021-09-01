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
            this._projectViewControl = new ProjectViewer.View.ModelViewControl();
            this.SuspendLayout();
            // 
            // _projectViewControl
            // 
            this._projectViewControl.Location = new System.Drawing.Point(2, -1);
            this._projectViewControl.Name = "_projectViewControl";
            this._projectViewControl.Size = new System.Drawing.Size(600, 400);
            this._projectViewControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 404);
            this.Controls.Add(this._projectViewControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private ProjectViewer.View.ModelViewControl _projectViewControl;

        #endregion
    }
}