namespace Project_Management_System.Views.Administrator.View_Views
{
    partial class ViewTasksView
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
            this.listViewTasks = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonFilter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBoxDeadline = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listViewTasks
            // 
            this.listViewTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewTasks.Depth = 0;
            this.listViewTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViewTasks.FullRowSelect = true;
            this.listViewTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewTasks.Location = new System.Drawing.Point(0, 75);
            this.listViewTasks.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewTasks.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewTasks.MultiSelect = false;
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.OwnerDraw = true;
            this.listViewTasks.Size = new System.Drawing.Size(667, 415);
            this.listViewTasks.TabIndex = 2;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Progress (%)";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Deadline";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Description";
            this.columnHeader6.Width = 137;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "User Full Name";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Project Name";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(19, 19);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(52, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(79, 19);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(133, 21);
            this.comboBoxStatus.TabIndex = 4;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(220, 19);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(67, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Deadline";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(79, 48);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(133, 21);
            this.comboBoxUser.TabIndex = 8;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(19, 48);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(40, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "User";
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(293, 46);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(133, 21);
            this.comboBoxProject.TabIndex = 10;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(220, 46);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(57, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Project";
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
            this.buttonFilter.TabIndex = 11;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
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
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBoxDeadline
            // 
            this.comboBoxDeadline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeadline.FormattingEnabled = true;
            this.comboBoxDeadline.Location = new System.Drawing.Point(293, 19);
            this.comboBoxDeadline.Name = "comboBoxDeadline";
            this.comboBoxDeadline.Size = new System.Drawing.Size(133, 21);
            this.comboBoxDeadline.TabIndex = 13;
            // 
            // ViewTasksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 490);
            this.Controls.Add(this.comboBoxDeadline);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.comboBoxProject);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.listViewTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewTasksView";
            this.Text = "ViewTasksView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewTasks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton buttonFilter;
        private MaterialSkin.Controls.MaterialRaisedButton buttonReset;
        private System.Windows.Forms.ComboBox comboBoxDeadline;
    }
}