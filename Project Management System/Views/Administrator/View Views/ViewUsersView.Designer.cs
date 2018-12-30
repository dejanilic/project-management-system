namespace Project_Management_System.Views.Administrator.View_Views
{
    partial class ViewUsersView
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
            this.listViewUsers = new MaterialSkin.Controls.MaterialListView();
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonFilter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // listViewUsers
            // 
            this.listViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.username,
            this.password,
            this.name,
            this.surname,
            this.email,
            this.Role});
            this.listViewUsers.Depth = 0;
            this.listViewUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewUsers.Location = new System.Drawing.Point(0, 75);
            this.listViewUsers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewUsers.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewUsers.MultiSelect = false;
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.OwnerDraw = true;
            this.listViewUsers.Size = new System.Drawing.Size(667, 415);
            this.listViewUsers.TabIndex = 2;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // username
            // 
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.Text = "Password";
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // surname
            // 
            this.surname.Text = "Surname";
            // 
            // email
            // 
            this.email.Text = "Email";
            // 
            // Role
            // 
            this.Role.Text = "Role";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(19, 19);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(39, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Role";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(64, 19);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(133, 21);
            this.comboBoxRole.TabIndex = 4;
            // 
            // buttonFilter
            // 
            this.buttonFilter.AutoSize = true;
            this.buttonFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFilter.Depth = 0;
            this.buttonFilter.Icon = null;
            this.buttonFilter.Location = new System.Drawing.Point(502, 11);
            this.buttonFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Primary = true;
            this.buttonFilter.Size = new System.Drawing.Size(64, 36);
            this.buttonFilter.TabIndex = 5;
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
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ViewUsersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 490);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.listViewUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewUsersView";
            this.Text = "ViewUsersView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewUsers;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader password;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader Role;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private MaterialSkin.Controls.MaterialRaisedButton buttonFilter;
        private MaterialSkin.Controls.MaterialRaisedButton buttonReset;
    }
}