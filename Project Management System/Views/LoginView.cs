using MaterialSkin;
using Project_Management_System.Models;
using Project_Management_System.Presenters;
using Project_Management_System.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class Login : MaterialSkin.Controls.MaterialForm, ILoginView
    {
        LoginViewPresenter presenter;

        public Login()
        {
            InitializeComponent();
            presenter = new LoginViewPresenter(this, this);
        }

        public string Password
        {
            get
            {
                return textFieldPassword.Text;
            }
        }

        public string Username
        {
            get
            {
                return textFieldUsername.Text;
            }
        }

        public void showMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            presenter.login();
        }
    }
}
