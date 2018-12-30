namespace Project_Management_System.Views
{
    partial class AdministratorAddMenuView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorAddMenuView));
            this.buttonNewProject = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonNewTask = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonNewUser = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // buttonNewProject
            // 
            this.buttonNewProject.AutoSize = true;
            this.buttonNewProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewProject.BackColor = System.Drawing.Color.White;
            this.buttonNewProject.Depth = 0;
            this.buttonNewProject.Icon = ((System.Drawing.Image)(resources.GetObject("buttonNewProject.Icon")));
            this.buttonNewProject.Location = new System.Drawing.Point(0, 25);
            this.buttonNewProject.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonNewProject.MinimumSize = new System.Drawing.Size(150, 39);
            this.buttonNewProject.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewProject.Name = "buttonNewProject";
            this.buttonNewProject.Primary = false;
            this.buttonNewProject.Size = new System.Drawing.Size(150, 39);
            this.buttonNewProject.TabIndex = 0;
            this.buttonNewProject.Text = "Project";
            this.buttonNewProject.UseVisualStyleBackColor = false;
            this.buttonNewProject.Click += new System.EventHandler(this.buttonNewProject_Click);
            // 
            // buttonNewTask
            // 
            this.buttonNewTask.AutoSize = true;
            this.buttonNewTask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewTask.BackColor = System.Drawing.Color.White;
            this.buttonNewTask.Depth = 0;
            this.buttonNewTask.Icon = ((System.Drawing.Image)(resources.GetObject("buttonNewTask.Icon")));
            this.buttonNewTask.Location = new System.Drawing.Point(0, 66);
            this.buttonNewTask.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonNewTask.MinimumSize = new System.Drawing.Size(150, 39);
            this.buttonNewTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewTask.Name = "buttonNewTask";
            this.buttonNewTask.Primary = false;
            this.buttonNewTask.Size = new System.Drawing.Size(150, 39);
            this.buttonNewTask.TabIndex = 1;
            this.buttonNewTask.Text = "Task";
            this.buttonNewTask.UseVisualStyleBackColor = false;
            this.buttonNewTask.Click += new System.EventHandler(this.buttonNewTask_Click);
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.AutoSize = true;
            this.buttonNewUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewUser.BackColor = System.Drawing.Color.White;
            this.buttonNewUser.Depth = 0;
            this.buttonNewUser.Icon = ((System.Drawing.Image)(resources.GetObject("buttonNewUser.Icon")));
            this.buttonNewUser.Location = new System.Drawing.Point(0, 107);
            this.buttonNewUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonNewUser.MinimumSize = new System.Drawing.Size(150, 39);
            this.buttonNewUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Primary = false;
            this.buttonNewUser.Size = new System.Drawing.Size(150, 39);
            this.buttonNewUser.TabIndex = 2;
            this.buttonNewUser.Text = "User";
            this.buttonNewUser.UseVisualStyleBackColor = false;
            this.buttonNewUser.Click += new System.EventHandler(this.buttonNewUser_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(0, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Add menu";
            // 
            // AdministratorAddMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(150, 500);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.buttonNewUser);
            this.Controls.Add(this.buttonNewTask);
            this.Controls.Add(this.buttonNewProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministratorAddMenuView";
            this.Text = "AddMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton buttonNewProject;
        private MaterialSkin.Controls.MaterialFlatButton buttonNewTask;
        private MaterialSkin.Controls.MaterialFlatButton buttonNewUser;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}