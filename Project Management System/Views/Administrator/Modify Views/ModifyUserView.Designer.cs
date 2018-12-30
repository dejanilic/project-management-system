namespace Project_Management_System.Views.Administrator.Modify_Views
{
    partial class ModifyUserView
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
            this.buttonSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textFieldSurname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textFieldName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textFieldPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textFieldUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.listViewUsers = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.Depth = 0;
            this.buttonSave.Icon = null;
            this.buttonSave.Location = new System.Drawing.Point(307, 435);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(10);
            this.buttonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Primary = true;
            this.buttonSave.Size = new System.Drawing.Size(108, 36);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "modify user";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(457, 364);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(198, 21);
            this.comboBoxRole.TabIndex = 24;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(374, 366);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(39, 19);
            this.materialLabel6.TabIndex = 23;
            this.materialLabel6.Text = "Role";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(8, 366);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(47, 19);
            this.materialLabel5.TabIndex = 22;
            this.materialLabel5.Text = "Email";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(374, 337);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 19);
            this.materialLabel4.TabIndex = 21;
            this.materialLabel4.Text = "Surname";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 337);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(49, 19);
            this.materialLabel3.TabIndex = 20;
            this.materialLabel3.Text = "Name";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(374, 308);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Password";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 308);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Username";
            // 
            // textFieldEmail
            // 
            this.textFieldEmail.Depth = 0;
            this.textFieldEmail.Hint = "";
            this.textFieldEmail.Location = new System.Drawing.Point(93, 362);
            this.textFieldEmail.MaxLength = 32767;
            this.textFieldEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldEmail.Name = "textFieldEmail";
            this.textFieldEmail.PasswordChar = '\0';
            this.textFieldEmail.SelectedText = "";
            this.textFieldEmail.SelectionLength = 0;
            this.textFieldEmail.SelectionStart = 0;
            this.textFieldEmail.Size = new System.Drawing.Size(198, 23);
            this.textFieldEmail.TabIndex = 17;
            this.textFieldEmail.TabStop = false;
            this.textFieldEmail.UseSystemPasswordChar = false;
            // 
            // textFieldSurname
            // 
            this.textFieldSurname.Depth = 0;
            this.textFieldSurname.Hint = "";
            this.textFieldSurname.Location = new System.Drawing.Point(457, 333);
            this.textFieldSurname.MaxLength = 32767;
            this.textFieldSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldSurname.Name = "textFieldSurname";
            this.textFieldSurname.PasswordChar = '\0';
            this.textFieldSurname.SelectedText = "";
            this.textFieldSurname.SelectionLength = 0;
            this.textFieldSurname.SelectionStart = 0;
            this.textFieldSurname.Size = new System.Drawing.Size(198, 23);
            this.textFieldSurname.TabIndex = 16;
            this.textFieldSurname.TabStop = false;
            this.textFieldSurname.UseSystemPasswordChar = false;
            // 
            // textFieldName
            // 
            this.textFieldName.Depth = 0;
            this.textFieldName.Hint = "";
            this.textFieldName.Location = new System.Drawing.Point(93, 333);
            this.textFieldName.MaxLength = 32767;
            this.textFieldName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldName.Name = "textFieldName";
            this.textFieldName.PasswordChar = '\0';
            this.textFieldName.SelectedText = "";
            this.textFieldName.SelectionLength = 0;
            this.textFieldName.SelectionStart = 0;
            this.textFieldName.Size = new System.Drawing.Size(198, 23);
            this.textFieldName.TabIndex = 15;
            this.textFieldName.TabStop = false;
            this.textFieldName.UseSystemPasswordChar = false;
            // 
            // textFieldPassword
            // 
            this.textFieldPassword.Depth = 0;
            this.textFieldPassword.Hint = "";
            this.textFieldPassword.Location = new System.Drawing.Point(457, 308);
            this.textFieldPassword.MaxLength = 32767;
            this.textFieldPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldPassword.Name = "textFieldPassword";
            this.textFieldPassword.PasswordChar = '\0';
            this.textFieldPassword.SelectedText = "";
            this.textFieldPassword.SelectionLength = 0;
            this.textFieldPassword.SelectionStart = 0;
            this.textFieldPassword.Size = new System.Drawing.Size(198, 23);
            this.textFieldPassword.TabIndex = 14;
            this.textFieldPassword.TabStop = false;
            this.textFieldPassword.UseSystemPasswordChar = false;
            // 
            // textFieldUsername
            // 
            this.textFieldUsername.Depth = 0;
            this.textFieldUsername.Hint = "";
            this.textFieldUsername.Location = new System.Drawing.Point(93, 304);
            this.textFieldUsername.MaxLength = 32767;
            this.textFieldUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldUsername.Name = "textFieldUsername";
            this.textFieldUsername.PasswordChar = '\0';
            this.textFieldUsername.SelectedText = "";
            this.textFieldUsername.SelectionLength = 0;
            this.textFieldUsername.SelectionStart = 0;
            this.textFieldUsername.Size = new System.Drawing.Size(198, 23);
            this.textFieldUsername.TabIndex = 13;
            this.textFieldUsername.TabStop = false;
            this.textFieldUsername.UseSystemPasswordChar = false;
            // 
            // listViewUsers
            // 
            this.listViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewUsers.Depth = 0;
            this.listViewUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewUsers.Location = new System.Drawing.Point(0, 0);
            this.listViewUsers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewUsers.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.OwnerDraw = true;
            this.listViewUsers.Size = new System.Drawing.Size(667, 298);
            this.listViewUsers.TabIndex = 26;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Surname";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Role";
            // 
            // ModifyUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 490);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textFieldEmail);
            this.Controls.Add(this.textFieldSurname);
            this.Controls.Add(this.textFieldName);
            this.Controls.Add(this.textFieldPassword);
            this.Controls.Add(this.textFieldUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "ModifyUserView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton buttonSave;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldSurname;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldName;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldUsername;
        private MaterialSkin.Controls.MaterialListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}