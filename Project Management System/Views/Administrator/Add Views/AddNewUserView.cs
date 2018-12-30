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

namespace Project_Management_System.Views.Administrator.Add_Views
{
    public partial class AddNewUserView : Form, IAddNewUserView
    {
        AddNewUserViewPresenter presenter;

        public AddNewUserView()
        {
            InitializeComponent();
            presenter = new AddNewUserViewPresenter(this);
            presenter.initRoles();
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
            presenter.addNewUser();
        }
    }
}
