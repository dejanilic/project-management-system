using Project_Management_System.Models;
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
    public partial class AddNewProjectView : Form, IAddNewProjectView
    {
        AddNewProjectViewPresenter presenter;

        public AddNewProjectView()
        {
            InitializeComponent();
            presenter = new AddNewProjectViewPresenter(this);
            presenter.initCBox();
        }

        public ComboBox cBox
        {
            get
            {
                return comboBoxProjectManager;
            }
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
