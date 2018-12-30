namespace Project_Management_System.Views
{
    partial class AdministratorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorView));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonView = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonModify = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelLeftTop = new System.Windows.Forms.Panel();
            this.buttonAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.panelAddMenu = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelLeftTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.DimGray;
            this.panelLeft.Controls.Add(this.buttonView);
            this.panelLeft.Controls.Add(this.buttonModify);
            this.panelLeft.Controls.Add(this.buttonDelete);
            this.panelLeft.Location = new System.Drawing.Point(0, 24);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 533);
            this.panelLeft.TabIndex = 0;
            // 
            // buttonView
            // 
            this.buttonView.AutoSize = true;
            this.buttonView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonView.BackColor = System.Drawing.Color.White;
            this.buttonView.Depth = 0;
            this.buttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.ForeColor = System.Drawing.Color.White;
            this.buttonView.Icon = ((System.Drawing.Image)(resources.GetObject("buttonView.Icon")));
            this.buttonView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonView.Location = new System.Drawing.Point(0, 133);
            this.buttonView.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonView.MinimumSize = new System.Drawing.Size(200, 39);
            this.buttonView.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonView.Name = "buttonView";
            this.buttonView.Primary = false;
            this.buttonView.Size = new System.Drawing.Size(200, 39);
            this.buttonView.TabIndex = 3;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.AutoSize = true;
            this.buttonModify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonModify.BackColor = System.Drawing.Color.White;
            this.buttonModify.Depth = 0;
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.ForeColor = System.Drawing.Color.White;
            this.buttonModify.Icon = ((System.Drawing.Image)(resources.GetObject("buttonModify.Icon")));
            this.buttonModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModify.Location = new System.Drawing.Point(0, 51);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonModify.MinimumSize = new System.Drawing.Size(200, 39);
            this.buttonModify.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Primary = false;
            this.buttonModify.Size = new System.Drawing.Size(200, 39);
            this.buttonModify.TabIndex = 1;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.Depth = 0;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Icon = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Icon")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(0, 92);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDelete.MinimumSize = new System.Drawing.Size(200, 39);
            this.buttonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Primary = false;
            this.buttonDelete.Size = new System.Drawing.Size(200, 39);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.BackColor = System.Drawing.Color.DimGray;
            this.panelLeftTop.Controls.Add(this.buttonAdd);
            this.panelLeftTop.Location = new System.Drawing.Point(0, 24);
            this.panelLeftTop.Name = "panelLeftTop";
            this.panelLeftTop.Size = new System.Drawing.Size(200, 39);
            this.panelLeftTop.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.Depth = 0;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAdd.Icon = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Icon")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAdd.MinimumSize = new System.Drawing.Size(200, 39);
            this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Primary = false;
            this.buttonAdd.Size = new System.Drawing.Size(200, 39);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelDivider
            // 
            this.panelDivider.BackColor = System.Drawing.Color.DimGray;
            this.panelDivider.Location = new System.Drawing.Point(198, 24);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(2, 530);
            this.panelDivider.TabIndex = 2;
            // 
            // panelAddMenu
            // 
            this.panelAddMenu.BackColor = System.Drawing.Color.White;
            this.panelAddMenu.Location = new System.Drawing.Point(200, 64);
            this.panelAddMenu.Name = "panelAddMenu";
            this.panelAddMenu.Size = new System.Drawing.Size(150, 500);
            this.panelAddMenu.TabIndex = 4;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Location = new System.Drawing.Point(350, 64);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(667, 490);
            this.panelMain.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Project Management System - Home";
            // 
            // AdministratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1015, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelAddMenu);
            this.Controls.Add(this.panelDivider);
            this.Controls.Add(this.panelLeftTop);
            this.Controls.Add(this.panelLeft);
            this.Name = "AdministratorView";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelLeftTop.ResumeLayout(false);
            this.panelLeftTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelLeftTop;
        private System.Windows.Forms.Panel panelDivider;
        private MaterialSkin.Controls.MaterialFlatButton buttonAdd;
        private MaterialSkin.Controls.MaterialFlatButton buttonDelete;
        private MaterialSkin.Controls.MaterialFlatButton buttonModify;
        private MaterialSkin.Controls.MaterialFlatButton buttonView;
        private System.Windows.Forms.Panel panelAddMenu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
    }
}