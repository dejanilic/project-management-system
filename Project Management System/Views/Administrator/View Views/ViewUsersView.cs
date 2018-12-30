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
    public partial class ViewUsersView : Form, IViewUsersView
    {
        ViewUsersViewPresenter presenter;

        public ViewUsersView()
        {
            InitializeComponent();
            presenter = new ViewUsersViewPresenter(this);
            presenter.initList();
            Util.expandListViewHeader(List);
        }

        public ListView List
        {
            get
            {
                return listViewUsers;
            }
        }

        ComboBox IViewUsersView.Role
        {
            get
            {
                return comboBoxRole;
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
