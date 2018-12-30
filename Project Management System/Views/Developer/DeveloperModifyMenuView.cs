using Project_Management_System.Presenters.Developer;
using Project_Management_System.Views.Developer.Modify;
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
    public partial class DeveloperModifyMenuView : Form, IDeveloperModifyMenuView
    {
        private Panel panel;
        DeveloperModifyMenuViewPresenter presenter;

        public DeveloperModifyMenuView(Panel panel, int userId)
        {
            InitializeComponent();
            presenter = new DeveloperModifyMenuViewPresenter(this, userId);
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
