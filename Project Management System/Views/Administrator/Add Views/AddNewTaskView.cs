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
    public partial class AddNewTaskView : Form, IAddNewTaskView
    {
        AddNewTaskViewPresenter presenter;

        public AddNewTaskView()
        {
            InitializeComponent();
            this.presenter = new AddNewTaskViewPresenter(this);
            presenter.initStatus();
            presenter.initUsers();
            presenter.initProjects();
        }

        public DateTimePicker Deadline
        {
            get
            {
                return dateTimePickerDeadline;
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

        public string Description
        {
            get
            {
                return textFieldDescription.Text;
            }

            set
            {
                textFieldDescription.Text = value;
            }
        }

        public string Progress
        {
            get
            {
                return textFieldProgress.Text;
            }

            set
            {
                textFieldProgress.Text = value;
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

        public ComboBox Project
        {
            get
            {
                return comboBoxProject;
            }
        }

        public void showMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            presenter.addNewTask();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.initProgress();
        }
    }
}
