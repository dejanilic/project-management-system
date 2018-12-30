using Project_Management_System.Presenters.Developer;
using Project_Management_System.Views.Developer.View_Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Developer
{
    public partial class DeveloperViewMenuView : Form, IDeveloperViewMenuView
    {
        Panel panel;
        DeveloperViewMenuViewPresenter presenter;

        public DeveloperViewMenuView(Panel panel, int userid)
        {
            InitializeComponent();
            presenter = new DeveloperViewMenuViewPresenter(this, userid);
            this.panel = panel;
        }

        public Panel Panel
        {
            get
            {
                return panel;
            }
        }

        private void buttonViewTask_Click(object sender, EventArgs e)
        {
            presenter.viewTasks();
        }
    }
}
