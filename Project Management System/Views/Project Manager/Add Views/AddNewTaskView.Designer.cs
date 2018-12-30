namespace Project_Management_System.Views.Project_Manager.Add_Views
{
    partial class AddNewTaskView
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
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textFieldProgress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textFieldName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(176, 330);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(10);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(57, 19);
            this.materialLabel7.TabIndex = 30;
            this.materialLabel7.Text = "Project";
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(275, 328);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(211, 21);
            this.comboBoxProject.TabIndex = 29;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(176, 291);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(10);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(40, 19);
            this.materialLabel6.TabIndex = 28;
            this.materialLabel6.Text = "User";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(275, 289);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(211, 21);
            this.comboBoxUser.TabIndex = 27;
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(275, 211);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(211, 20);
            this.dateTimePickerDeadline.TabIndex = 26;
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.Depth = 0;
            this.buttonSave.Icon = null;
            this.buttonSave.Location = new System.Drawing.Point(275, 362);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(10);
            this.buttonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Primary = true;
            this.buttonSave.Size = new System.Drawing.Size(119, 36);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "add new task";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(176, 252);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(10);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(86, 19);
            this.materialLabel5.TabIndex = 24;
            this.materialLabel5.Text = "Description";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(176, 213);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(10);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(67, 19);
            this.materialLabel4.TabIndex = 23;
            this.materialLabel4.Text = "Deadline";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(176, 174);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(10);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(69, 19);
            this.materialLabel3.TabIndex = 22;
            this.materialLabel3.Text = "Progress";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(176, 135);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(10);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(52, 19);
            this.materialLabel2.TabIndex = 21;
            this.materialLabel2.Text = "Status";
            // 
            // textFieldDescription
            // 
            this.textFieldDescription.Depth = 0;
            this.textFieldDescription.Hint = "";
            this.textFieldDescription.Location = new System.Drawing.Point(275, 248);
            this.textFieldDescription.MaxLength = 32767;
            this.textFieldDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldDescription.Name = "textFieldDescription";
            this.textFieldDescription.PasswordChar = '\0';
            this.textFieldDescription.SelectedText = "";
            this.textFieldDescription.SelectionLength = 0;
            this.textFieldDescription.SelectionStart = 0;
            this.textFieldDescription.Size = new System.Drawing.Size(211, 23);
            this.textFieldDescription.TabIndex = 19;
            this.textFieldDescription.TabStop = false;
            this.textFieldDescription.UseSystemPasswordChar = false;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(275, 133);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(211, 21);
            this.comboBoxStatus.TabIndex = 18;
            // 
            // textFieldProgress
            // 
            this.textFieldProgress.Depth = 0;
            this.textFieldProgress.Hint = "";
            this.textFieldProgress.Location = new System.Drawing.Point(275, 170);
            this.textFieldProgress.MaxLength = 32767;
            this.textFieldProgress.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldProgress.Name = "textFieldProgress";
            this.textFieldProgress.PasswordChar = '\0';
            this.textFieldProgress.SelectedText = "";
            this.textFieldProgress.SelectionLength = 0;
            this.textFieldProgress.SelectionStart = 0;
            this.textFieldProgress.Size = new System.Drawing.Size(211, 23);
            this.textFieldProgress.TabIndex = 17;
            this.textFieldProgress.TabStop = false;
            this.textFieldProgress.UseSystemPasswordChar = false;
            // 
            // textFieldName
            // 
            this.textFieldName.Depth = 0;
            this.textFieldName.Hint = "";
            this.textFieldName.Location = new System.Drawing.Point(275, 92);
            this.textFieldName.MaxLength = 32767;
            this.textFieldName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldName.Name = "textFieldName";
            this.textFieldName.PasswordChar = '\0';
            this.textFieldName.SelectedText = "";
            this.textFieldName.SelectionLength = 0;
            this.textFieldName.SelectionStart = 0;
            this.textFieldName.Size = new System.Drawing.Size(211, 23);
            this.textFieldName.TabIndex = 16;
            this.textFieldName.TabStop = false;
            this.textFieldName.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(176, 96);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "Name";
            // 
            // AddNewTaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 490);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.comboBoxProject);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.dateTimePickerDeadline);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textFieldDescription);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textFieldProgress);
            this.Controls.Add(this.textFieldName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "AddNewTaskView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldDescription;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldProgress;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}