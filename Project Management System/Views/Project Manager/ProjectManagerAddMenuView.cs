using Project_Management_System.Models;
using Project_Management_System.Presenters.Project_Manager;
using Project_Management_System.Views.Project_Manager.Add_Views;
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
    public partial class ProjectManagerAddMenuView : Form, IProjectManagerAddMenuView
    {
        private Panel panel;
        ProjectManagerAddMenuViewPresenter presenter;

        public ProjectManagerAddMenuView(Panel panel, int userid)
        {
            InitializeComponent();
            presenter = new ProjectManagerAddMenuViewPresenter(this, userid);
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
            presenter.initAddNewProjectView();
        }

        private void buttonNewTask_Click(object sender, EventArgs e)
        {
            presenter.initAddNewTaskView();
        }
    }
}
