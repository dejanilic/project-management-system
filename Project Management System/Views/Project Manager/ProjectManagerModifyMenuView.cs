using Project_Management_System.Presenters.Project_Manager;
using Project_Management_System.Views.Project_Manager.Modify_Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Project_Manager
{
    public partial class ProjectManagerModifyMenuView : Form, IProjectManagerModifyMenuView
    {
        private Panel panel;
        ProjectManagerModifyMenuViewPresenter presenter;

        public ProjectManagerModifyMenuView(Panel panel, int userid)
        {
            InitializeComponent();
            presenter = new ProjectManagerModifyMenuViewPresenter(this, userid);
            this.panel = panel;
        }

        public Panel Panel
        {
            get
            {
                return panel;
            }
        }

        private void buttonNewTask_Click(object sender, EventArgs e)
        {
            presenter.initModifyTaskView();
        }
    }
}
