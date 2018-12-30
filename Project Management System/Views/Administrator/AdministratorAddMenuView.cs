using Project_Management_System.Presenters;
using Project_Management_System.Views.Administrator.Add_Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views
{
    public partial class AdministratorAddMenuView : Form, IAdministratorAddMenuView
    {
        private Panel panel;
        AdministratorAddMenuViewPresenter presenter;

        public AdministratorAddMenuView(Panel panel)
        {
            InitializeComponent();
            presenter = new AdministratorAddMenuViewPresenter(this);
            this.panel = panel;
        }

        Panel IAdministratorAddMenuView.Panel
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

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            presenter.initAddNewUserView();
        }
    }
}
