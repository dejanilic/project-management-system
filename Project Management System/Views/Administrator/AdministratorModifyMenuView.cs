using Project_Management_System.Presenters;
using Project_Management_System.Views.Administrator.Modify_Views;
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
    public partial class AdministratorModifyMenuView : Form, IAdministratorModifyMenuView
    {
        private Panel panel;
        AdministratorModifyMenuViewPresenter presenter;

        public AdministratorModifyMenuView(Panel panel)
        {
            InitializeComponent();
            presenter = new AdministratorModifyMenuViewPresenter(this);
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
            presenter.initModifyProjectView();
        }

        private void buttonNewTask_Click(object sender, EventArgs e)
        {
            presenter.initModifyTaskView();
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            presenter.initModifyUserView();
        }
    }
}
