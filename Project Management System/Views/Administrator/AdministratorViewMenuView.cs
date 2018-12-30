using Project_Management_System.Presenters;
using Project_Management_System.Views.Administrator.View_Views;
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
    public partial class AdministratorViewMenuView : Form, IAdministratorViewMenuView
    {
        Panel panel;
        AdministratorViewMenuViewPresenter presenter;

        public AdministratorViewMenuView(Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
            presenter = new AdministratorViewMenuViewPresenter(this);
        }

        Panel IAdministratorViewMenuView.Panel
        {
            get
            {
                return panel;
            }
        }

        private void buttonViewProject_Click(object sender, EventArgs e)
        {
            presenter.viewProjects();
        }

        private void buttonViewTask_Click(object sender, EventArgs e)
        {
            presenter.viewTasks();
        }

        private void buttonViewUser_Click(object sender, EventArgs e)
        {
            presenter.viewUsers();
        }
    }
}
