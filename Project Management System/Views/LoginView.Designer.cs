namespace Project_Management_System
{
    partial class Login
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
            this.textFieldUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textFieldUsername
            // 
            this.textFieldUsername.BackColor = System.Drawing.Color.White;
            this.textFieldUsername.Depth = 0;
            this.textFieldUsername.Hint = "";
            this.textFieldUsername.Location = new System.Drawing.Point(132, 155);
            this.textFieldUsername.MaxLength = 32767;
            this.textFieldUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldUsername.Name = "textFieldUsername";
            this.textFieldUsername.PasswordChar = '\0';
            this.textFieldUsername.SelectedText = "";
            this.textFieldUsername.SelectionLength = 0;
            this.textFieldUsername.SelectionStart = 0;
            this.textFieldUsername.Size = new System.Drawing.Size(161, 23);
            this.textFieldUsername.TabIndex = 0;
            this.textFieldUsername.TabStop = false;
            this.textFieldUsername.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(49, 155);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Username";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(49, 196);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Password";
            // 
            // textFieldPassword
            // 
            this.textFieldPassword.BackColor = System.Drawing.Color.White;
            this.textFieldPassword.Depth = 0;
            this.textFieldPassword.Hint = "";
            this.textFieldPassword.Location = new System.Drawing.Point(132, 196);
            this.textFieldPassword.MaxLength = 32767;
            this.textFieldPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldPassword.Name = "textFieldPassword";
            this.textFieldPassword.PasswordChar = '\0';
            this.textFieldPassword.SelectedText = "";
            this.textFieldPassword.SelectionLength = 0;
            this.textFieldPassword.SelectionStart = 0;
            this.textFieldPassword.Size = new System.Drawing.Size(161, 23);
            this.textFieldPassword.TabIndex = 2;
            this.textFieldPassword.TabStop = false;
            this.textFieldPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.Depth = 0;
            this.buttonLogin.Icon = null;
            this.buttonLogin.Location = new System.Drawing.Point(132, 247);
            this.buttonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Primary = true;
            this.buttonLogin.Size = new System.Drawing.Size(61, 36);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Project Management System - Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.textFieldPassword);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textFieldUsername);
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldUsername;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldPassword;
        private MaterialSkin.Controls.MaterialRaisedButton buttonLogin;
        private System.Windows.Forms.Label label1;
    }
}

