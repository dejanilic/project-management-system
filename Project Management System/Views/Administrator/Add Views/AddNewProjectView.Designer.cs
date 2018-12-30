namespace Project_Management_System.Views.Administrator.Add_Views
{
    partial class AddNewProjectView
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
            this.textFieldName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textFieldCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxProjectManager = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // textFieldName
            // 
            this.textFieldName.Depth = 0;
            this.textFieldName.Hint = "";
            this.textFieldName.Location = new System.Drawing.Point(300, 166);
            this.textFieldName.MaxLength = 32767;
            this.textFieldName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldName.Name = "textFieldName";
            this.textFieldName.PasswordChar = '\0';
            this.textFieldName.SelectedText = "";
            this.textFieldName.SelectionLength = 0;
            this.textFieldName.SelectionStart = 0;
            this.textFieldName.Size = new System.Drawing.Size(198, 23);
            this.textFieldName.TabIndex = 0;
            this.textFieldName.TabStop = false;
            this.textFieldName.UseSystemPasswordChar = false;
            // 
            // textFieldCode
            // 
            this.textFieldCode.Depth = 0;
            this.textFieldCode.Hint = "";
            this.textFieldCode.Location = new System.Drawing.Point(300, 205);
            this.textFieldCode.MaxLength = 32767;
            this.textFieldCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldCode.Name = "textFieldCode";
            this.textFieldCode.PasswordChar = '\0';
            this.textFieldCode.SelectedText = "";
            this.textFieldCode.SelectionLength = 0;
            this.textFieldCode.SelectionStart = 0;
            this.textFieldCode.Size = new System.Drawing.Size(198, 23);
            this.textFieldCode.TabIndex = 1;
            this.textFieldCode.TabStop = false;
            this.textFieldCode.UseSystemPasswordChar = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.Depth = 0;
            this.buttonAdd.Icon = null;
            this.buttonAdd.Location = new System.Drawing.Point(300, 283);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Primary = true;
            this.buttonAdd.Size = new System.Drawing.Size(144, 36);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add new project";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(168, 170);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Name";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(168, 209);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(10);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(44, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Code";
            // 
            // comboBoxProjectManager
            // 
            this.comboBoxProjectManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjectManager.FormattingEnabled = true;
            this.comboBoxProjectManager.Location = new System.Drawing.Point(300, 249);
            this.comboBoxProjectManager.Name = "comboBoxProjectManager";
            this.comboBoxProjectManager.Size = new System.Drawing.Size(198, 21);
            this.comboBoxProjectManager.TabIndex = 5;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(168, 248);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(10);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(119, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Project manager";
            // 
            // AddNewProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(667, 490);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.comboBoxProjectManager);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textFieldCode);
            this.Controls.Add(this.textFieldName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "AddNewProjectView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldName;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldCode;
        private MaterialSkin.Controls.MaterialRaisedButton buttonAdd;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox comboBoxProjectManager;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}