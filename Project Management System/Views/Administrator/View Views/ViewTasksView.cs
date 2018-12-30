using Project_Management_System.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Administrator.View_Views
{
    public partial class ViewTasksView : Form, IViewTasksView
    {
        ViewTasksViewPresenter presenter;

        public ViewTasksView()
        {
            InitializeComponent();
            presenter = new ViewTasksViewPresenter(this);
            presenter.initList();
            Util.expandListViewHeader(List);
        }

        public ComboBox Deadline
        {
            get
            {
                return comboBoxDeadline;
            }
        }

        public ListView List
        {
            get
            {
                return listViewTasks;
            }
        }

        public ComboBox Project
        {
            get
            {
                return comboBoxProject;
            }
        }

        public ComboBox Status
        {
            get
            {
                return comboBoxStatus;
            }
        }

        public ComboBox User
        {
            get
            {
                return comboBoxUser;
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            presenter.filter();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            presenter.reset();
        }
    }
}
