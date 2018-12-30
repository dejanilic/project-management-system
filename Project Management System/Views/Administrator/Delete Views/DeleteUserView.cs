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

namespace Project_Management_System.Views.Administrator.Delete_Views
{
    public partial class DeleteUserView : Form, IDeleteUserView
    {
        DeleteUserViewPresenter presenter;

        public DeleteUserView()
        {
            InitializeComponent();
            presenter = new DeleteUserViewPresenter(this);
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

        public void showMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            presenter.deleteUser();
        }
    }
}
