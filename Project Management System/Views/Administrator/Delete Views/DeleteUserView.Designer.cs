namespace Project_Management_System.Views.Administrator.Delete_Views
{
    partial class DeleteUserView
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
            this.listViewUsers = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDelete.Depth = 0;
            this.buttonDelete.Icon = null;
            this.buttonDelete.Location = new System.Drawing.Point(300, 435);
            this.buttonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Primary = true;
            this.buttonDelete.Size = new System.Drawing.Size(106, 36);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete user";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listViewUsers
            // 
            this.listViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
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
            this.listViewUsers.MultiSelect = false;
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.OwnerDraw = true;
            this.listViewUsers.Size = new System.Drawing.Size(667, 422);
            this.listViewUsers.TabIndex = 4;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Password";
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
            // DeleteUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 490);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.buttonDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteUserView";
            this.Text = "DeleteUserView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton buttonDelete;
        private MaterialSkin.Controls.MaterialListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}