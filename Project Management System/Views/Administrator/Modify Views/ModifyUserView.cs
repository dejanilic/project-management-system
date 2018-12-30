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

namespace Project_Management_System.Views.Administrator.Modify_Views
{
    public partial class ModifyUserView : Form, IModifyUserView
    {
        ModifyUserViewPresenter presenter;

        public ModifyUserView()
        {
            InitializeComponent();
            presenter = new ModifyUserViewPresenter(this);
            presenter.initList();
            presenter.initRoles();
            Util.expandListViewHeader(List);
        }

        public string Email
        {
            get
            {
                return textFieldEmail.Text;
            }

            set
            {
                textFieldEmail.Text = value;
            }
        }

        public ListView List
        {
            get
            {
                return listViewUsers;
            }
        }

        public string Name
        {
            get
            {
                return textFieldName.Text;
            }

            set
            {
                textFieldName.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return textFieldPassword.Text;
            }

            set
            {
                textFieldPassword.Text = value;
            }
        }

        public ComboBox Role
        {
            get
            {
                return comboBoxRole;
            }

            set
            {
                comboBoxRole = null;
            }
        }

        public string Surname
        {
            get
            {
                return textFieldSurname.Text;
            }

            set
            {
                textFieldSurname.Text = value;
            }
        }

        public string Username
        {
            get
            {
                return textFieldUsername.Text;
            }

            set
            {
                textFieldUsername.Text = value;
            }
        }

        public void showMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            presenter.modifyUser();
            listViewUsers.Items.Clear();
            new ModifyUserViewPresenter(this).initList();
        }
    }
}
