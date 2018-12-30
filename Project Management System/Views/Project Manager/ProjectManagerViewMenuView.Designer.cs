namespace Project_Management_System.Views.Project_Manager
{
    partial class ProjectManagerViewMenuView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManagerViewMenuView));
            this.buttonNewProject = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonNewTask = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // buttonNewProject
            // 
            this.buttonNewProject.AutoSize = true;
            this.buttonNewProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewProject.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonNewProject.Depth = 0;
            this.buttonNewProject.Icon = ((System.Drawing.Image)(resources.GetObject("buttonNewProject.Icon")));
            this.buttonNewProject.Location = new System.Drawing.Point(0, 0);
            this.buttonNewProject.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonNewProject.MinimumSize = new System.Drawing.Size(150, 39);
            this.buttonNewProject.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewProject.Name = "buttonNewProject";
            this.buttonNewProject.Primary = false;
            this.buttonNewProject.Size = new System.Drawing.Size(150, 39);
            this.buttonNewProject.TabIndex = 4;
            this.buttonNewProject.Text = "Project";
            this.buttonNewProject.UseVisualStyleBackColor = false;
            this.buttonNewProject.Click += new System.EventHandler(this.buttonNewProject_Click);
            // 
            // buttonNewTask
            // 
            this.buttonNewTask.AutoSize = true;
            this.buttonNewTask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewTask.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonNewTask.Depth = 0;
            this.buttonNewTask.Icon = ((System.Drawing.Image)(resources.GetObject("buttonNewTask.Icon")));
            this.buttonNewTask.Location = new System.Drawing.Point(0, 41);
            this.buttonNewTask.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonNewTask.MinimumSize = new System.Drawing.Size(150, 39);
            this.buttonNewTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewTask.Name = "buttonNewTask";
            this.buttonNewTask.Primary = false;
            this.buttonNewTask.Size = new System.Drawing.Size(150, 39);
            this.buttonNewTask.TabIndex = 8;
            this.buttonNewTask.Text = "Task";
            this.buttonNewTask.UseVisualStyleBackColor = false;
            this.buttonNewTask.Click += new System.EventHandler(this.buttonNewTask_Click);
            // 
            // ProjectManagerViewMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(150, 500);
            this.Controls.Add(this.buttonNewTask);
            this.Controls.Add(this.buttonNewProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectManagerViewMenuView";
            this.Text = "ProjectManagerViewMenuView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton buttonNewProject;
        private MaterialSkin.Controls.MaterialFlatButton buttonNewTask;
    }
}