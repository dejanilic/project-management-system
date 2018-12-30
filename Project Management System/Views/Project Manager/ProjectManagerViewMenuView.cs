using Project_Management_System.Presenters.Project_Manager;
using Project_Management_System.Views.Project_Manager.View_Menu;
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
    public partial class ProjectManagerViewMenuView : Form, IProjectManagerViewMenuView
    {
        private Panel panel;
        ProjectManagerViewMenuViewPresenter presenter;

        public ProjectManagerViewMenuView(Panel panel, int userid)
        {
            InitializeComponent();
            presenter = new ProjectManagerViewMenuViewPresenter(this, userid);
            this.panel = panel;
        }

        public Panel Panel
        {
            get
            {
                return panel;
            }
        }

        private void buttonNewProject_Click(object sender, EventArgs e)
        {
            presenter.initViewProjectsView();
        }

        private void buttonNewTask_Click(object sender, EventArgs e)
        {
            presenter.initViewTasksView();
        }
    }
}
