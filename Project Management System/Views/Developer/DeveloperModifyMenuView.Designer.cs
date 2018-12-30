namespace Project_Management_System.Views.Developer
{
    partial class DeveloperModifyMenuView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeveloperModifyMenuView));
            this.buttonNewTask = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // buttonNewTask
            // 
            this.buttonNewTask.AutoSize = true;
            this.buttonNewTask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewTask.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonNewTask.Depth = 0;
            this.buttonNewTask.Icon = ((System.Drawing.Image)(resources.GetObject("buttonNewTask.Icon")));
            this.buttonNewTask.Location = new System.Drawing.Point(0, 0);
            this.buttonNewTask.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonNewTask.MinimumSize = new System.Drawing.Size(150, 39);
            this.buttonNewTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNewTask.Name = "buttonNewTask";
            this.buttonNewTask.Primary = false;
            this.buttonNewTask.Size = new System.Drawing.Size(150, 39);
            this.buttonNewTask.TabIndex = 5;
            this.buttonNewTask.Text = "Task";
            this.buttonNewTask.UseVisualStyleBackColor = false;
            this.buttonNewTask.Click += new System.EventHandler(this.buttonNewTask_Click);
            // 
            // DeveloperModifyMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(150, 500);
            this.Controls.Add(this.buttonNewTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeveloperModifyMenuView";
            this.Text = "DeveloperModifyMenuView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton buttonNewTask;
    }
}