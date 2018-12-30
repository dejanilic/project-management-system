namespace Project_Management_System.Views.Administrator.Modify_Views
{
    partial class ModifyProjectView
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
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxProjectManager = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textFieldCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textFieldName = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            this.listViewProjects.Location = new System.Drawing.Point(0, 0);
            this.listViewProjects.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewProjects.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewProjects.MultiSelect = false;
            this.listViewProjects.Name = "listViewProjects";
            this.listViewProjects.OwnerDraw = true;
            this.listViewProjects.Size = new System.Drawing.Size(667, 298);
            this.listViewProjects.TabIndex = 0;
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
            this.materialLabel3.Size = new System.Drawing.Size(119, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Project manager";
            // 
            // comboBoxProjectManager
            // 
            this.comboBoxProjectManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjectManager.FormattingEnabled = true;
            this.comboBoxProjectManager.Location = new System.Drawing.Point(135, 338);
            this.comboBoxProjectManager.Name = "comboBoxProjectManager";
            this.comboBoxProjectManager.Size = new System.Drawing.Size(198, 21);
            this.comboBoxProjectManager.TabIndex = 12;
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
            this.materialLabel2.Size = new System.Drawing.Size(44, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Code";
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
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Name";
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
            this.buttonSave.Size = new System.Drawing.Size(134, 36);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "modify project";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textFieldCode
            // 
            this.textFieldCode.Depth = 0;
            this.textFieldCode.Hint = "";
            this.textFieldCode.Location = new System.Drawing.Point(426, 308);
            this.textFieldCode.MaxLength = 32767;
            this.textFieldCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldCode.Name = "textFieldCode";
            this.textFieldCode.PasswordChar = '\0';
            this.textFieldCode.SelectedText = "";
            this.textFieldCode.SelectionLength = 0;
            this.textFieldCode.SelectionStart = 0;
            this.textFieldCode.Size = new System.Drawing.Size(198, 23);
            this.textFieldCode.TabIndex = 8;
            this.textFieldCode.TabStop = false;
            this.textFieldCode.UseSystemPasswordChar = false;
            // 
            // textFieldName
            // 
            this.textFieldName.Depth = 0;
            this.textFieldName.Hint = "";
            this.textFieldName.Location = new System.Drawing.Point(135, 304);
            this.textFieldName.MaxLength = 32767;
            this.textFieldName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldName.Name = "textFieldName";
            this.textFieldName.PasswordChar = '\0';
            this.textFieldName.SelectedText = "";
            this.textFieldName.SelectionLength = 0;
            this.textFieldName.SelectionStart = 0;
            this.textFieldName.Size = new System.Drawing.Size(198, 23);
            this.textFieldName.TabIndex = 7;
            this.textFieldName.TabStop = false;
            this.textFieldName.UseSystemPasswordChar = false;
            // 
            // ModifyProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 490);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.comboBoxProjectManager);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textFieldCode);
            this.Controls.Add(this.textFieldName);
            this.Controls.Add(this.listViewProjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "ModifyProjectView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewProjects;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox comboBoxProjectManager;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSave;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldCode;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldName;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader ProjectManager;
    }
}