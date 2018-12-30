namespace Project_Management_System.Views.Administrator.View_Views
{
    partial class ViewProjectsView
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
            this.listViewProjects = new MaterialSkin.Controls.MaterialListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProjectManager = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonFilter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBoxProjectManager = new System.Windows.Forms.ComboBox();
            this.buttonReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
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
            this.listViewProjects.Location = new System.Drawing.Point(0, 75);
            this.listViewProjects.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewProjects.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewProjects.MultiSelect = false;
            this.listViewProjects.Name = "listViewProjects";
            this.listViewProjects.OwnerDraw = true;
            this.listViewProjects.Size = new System.Drawing.Size(667, 415);
            this.listViewProjects.TabIndex = 1;
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
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(19, 19);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(10);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(119, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Project manager";
            // 
            // buttonFilter
            // 
            this.buttonFilter.AutoSize = true;
            this.buttonFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFilter.Depth = 0;
            this.buttonFilter.Icon = null;
            this.buttonFilter.Location = new System.Drawing.Point(502, 11);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(10);
            this.buttonFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Primary = true;
            this.buttonFilter.Size = new System.Drawing.Size(64, 36);
            this.buttonFilter.TabIndex = 4;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxProjectManager
            // 
            this.comboBoxProjectManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjectManager.FormattingEnabled = true;
            this.comboBoxProjectManager.Location = new System.Drawing.Point(151, 20);
            this.comboBoxProjectManager.Name = "comboBoxProjectManager";
            this.comboBoxProjectManager.Size = new System.Drawing.Size(133, 21);
            this.comboBoxProjectManager.TabIndex = 5;
            // 
            // buttonReset
            // 
            this.buttonReset.AutoSize = true;
            this.buttonReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReset.Depth = 0;
            this.buttonReset.Icon = null;
            this.buttonReset.Location = new System.Drawing.Point(586, 11);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(10);
            this.buttonReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Primary = true;
            this.buttonReset.Size = new System.Drawing.Size(62, 36);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ViewProjectsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 490);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.comboBoxProjectManager);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.listViewProjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialListView listViewProjects;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader ProjectManager;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton buttonFilter;
        private System.Windows.Forms.ComboBox comboBoxProjectManager;
        private MaterialSkin.Controls.MaterialRaisedButton buttonReset;
    }
}