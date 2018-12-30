using Project_Management_System.Presenters;
using Project_Management_System.Views.Administrator.Delete_Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Administrator
{
    public partial class AdministratorDeleteMenuView : Form, IAdministratorDeleteMenuView
    {
        private Panel panel;
        AdministratorDeleteMenuViewPresenter presenter;

        public AdministratorDeleteMenuView(Panel panel)
        {
            InitializeComponent();
            presenter = new AdministratorDeleteMenuViewPresenter(this);
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
            presenter.initDeleteProjectView();
        }

        private void buttonNewTask_Click(object sender, EventArgs e)
        {
            presenter.initDeleteTaskView();
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            presenter.initDeleteUserView();
        }
    }
}
