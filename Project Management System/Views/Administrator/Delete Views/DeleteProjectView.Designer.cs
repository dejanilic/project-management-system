namespace Project_Management_System.Views.Administrator.Delete_Views
{
    partial class DeleteProjectView
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
            this.buttonDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listViewProjects = new MaterialSkin.Controls.MaterialListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProjectManager = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDelete.Depth = 0;
            this.buttonDelete.Icon = null;
            this.buttonDelete.Location = new System.Drawing.Point(300, 435);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(10);
            this.buttonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Primary = true;
            this.buttonDelete.Size = new System.Drawing.Size(132, 36);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete project";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listViewProjects
            // 
            this.listViewProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.Name,
            this.ProjectManager});
            this.listViewProjects.Depth = 0;
            this.listViewProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViewProjects.FullRowSelect = true;
            this.listViewProjects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewProjects.Location = new System.Drawing.Point(0, 0);
            this.listViewProjects.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewProjects.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewProjects.MultiSelect = false;
            this.listViewProjects.Name = "listViewProjects";
            this.listViewProjects.OwnerDraw = true;
            this.listViewProjects.Size = new System.Drawing.Size(667, 422);
            this.listViewProjects.TabIndex = 2;
            this.listViewProjects.UseCompatibleStateImageBehavior = false;
            this.listViewProjects.View = System.Windows.Forms.View.Details;
            // 
            // Code
            // 
            this.Code.Text = "Code";
            this.Code.Width = 94;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 200;
            // 
            // ProjectManager
            // 
            this.ProjectManager.Text = "Project Manager";
            this.ProjectManager.Width = 343;
            // 
            // DeleteProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 490);
            this.Controls.Add(this.listViewProjects);
            this.Controls.Add(this.buttonDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "DeleteProjectView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton buttonDelete;
        private MaterialSkin.Controls.MaterialListView listViewProjects;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader ProjectManager;
    }
}