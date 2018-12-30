namespace Project_Management_System.Views.Developer
{
    partial class DeveloperViewMenuView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeveloperViewMenuView));
            this.buttonViewTask = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // buttonViewTask
            // 
            this.buttonViewTask.AutoSize = true;
            this.buttonViewTask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonViewTask.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonViewTask.Depth = 0;
            this.buttonViewTask.Icon = ((System.Drawing.Image)(resources.GetObject("buttonViewTask.Icon")));
            this.buttonViewTask.Location = new System.Drawing.Point(0, 0);
            this.buttonViewTask.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonViewTask.MinimumSize = new System.Drawing.Size(150, 39);
            this.buttonViewTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonViewTask.Name = "buttonViewTask";
            this.buttonViewTask.Primary = false;
            this.buttonViewTask.Size = new System.Drawing.Size(150, 39);
            this.buttonViewTask.TabIndex = 5;
            this.buttonViewTask.Text = "Task";
            this.buttonViewTask.UseVisualStyleBackColor = false;
            this.buttonViewTask.Click += new System.EventHandler(this.buttonViewTask_Click);
            // 
            // DeveloperViewMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(150, 500);
            this.Controls.Add(this.buttonViewTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeveloperViewMenuView";
            this.Text = "DeveloperViewMenuView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton buttonViewTask;
    }
}