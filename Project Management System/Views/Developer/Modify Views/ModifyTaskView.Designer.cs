namespace Project_Management_System.Views.Developer.Modify
{
    partial class ModifyTaskView
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
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textFieldProgress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonSave = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.listViewTasks.Location = new System.Drawing.Point(0, 0);
            this.listViewTasks.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewTasks.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewTasks.MultiSelect = false;
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.OwnerDraw = true;
            this.listViewTasks.Size = new System.Drawing.Size(667, 298);
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
            this.columnHeader6.Width = 181;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "User Full Name";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Project Name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 308);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(69, 19);
            this.materialLabel3.TabIndex = 24;
            this.materialLabel3.Text = "Progress";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(397, 310);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(52, 19);
            this.materialLabel2.TabIndex = 23;
            this.materialLabel2.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(457, 308);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(198, 21);
            this.comboBoxStatus.TabIndex = 22;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // textFieldProgress
            // 
            this.textFieldProgress.Depth = 0;
            this.textFieldProgress.Hint = "";
            this.textFieldProgress.Location = new System.Drawing.Point(102, 304);
            this.textFieldProgress.MaxLength = 32767;
            this.textFieldProgress.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldProgress.Name = "textFieldProgress";
            this.textFieldProgress.PasswordChar = '\0';
            this.textFieldProgress.SelectedText = "";
            this.textFieldProgress.SelectionLength = 0;
            this.textFieldProgress.SelectionStart = 0;
            this.textFieldProgress.Size = new System.Drawing.Size(198, 23);
            this.textFieldProgress.TabIndex = 21;
            this.textFieldProgress.TabStop = false;
            this.textFieldProgress.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(8, 337);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(86, 19);
            this.materialLabel5.TabIndex = 26;
            this.materialLabel5.Text = "Description";
            // 
            // textFieldDescription
            // 
            this.textFieldDescription.Depth = 0;
            this.textFieldDescription.Hint = "";
            this.textFieldDescription.Location = new System.Drawing.Point(102, 333);
            this.textFieldDescription.MaxLength = 32767;
            this.textFieldDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldDescription.Name = "textFieldDescription";
            this.textFieldDescription.PasswordChar = '\0';
            this.textFieldDescription.SelectedText = "";
            this.textFieldDescription.SelectionLength = 0;
            this.textFieldDescription.SelectionStart = 0;
            this.textFieldDescription.Size = new System.Drawing.Size(198, 23);
            this.textFieldDescription.TabIndex = 25;
            this.textFieldDescription.TabStop = false;
            this.textFieldDescription.UseSystemPasswordChar = false;
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.Depth = 0;
            this.buttonSave.Icon = null;
            this.buttonSave.Location = new System.Drawing.Point(307, 435);
            this.buttonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Primary = true;
            this.buttonSave.Size = new System.Drawing.Size(109, 36);
            this.buttonSave.TabIndex = 27;
            this.buttonSave.Text = "modify task";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ModifyTaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 490);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.textFieldDescription);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textFieldProgress);
            this.Controls.Add(this.listViewTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "ModifyTaskView";
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
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldProgress;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldDescription;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSave;
    }
}