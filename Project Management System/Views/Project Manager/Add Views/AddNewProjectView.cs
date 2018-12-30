using Project_Management_System.Presenters.Project_Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Project_Manager.Add_Views
{
    public partial class AddNewProjectView : Form, IAddNewProjectView
    {
        AddNewProjectViewPresenter presenter;

        public AddNewProjectView(int userid)
        {
            InitializeComponent();
            presenter = new AddNewProjectViewPresenter(this, userid);
            presenter.initUsers();
        }

        public string Code
        {
            get
            {
                return textFieldCode.Text;
            }
            set
            {
                textFieldCode.Text = value;
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

        public ComboBox Users
        {
            get
            {
                return comboBoxProjectManager;
            }

            set
            {
                comboBoxProjectManager.Text = value.Text;
            }
        }

        public void showMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            presenter.addNewProject();
        }
    }
}
