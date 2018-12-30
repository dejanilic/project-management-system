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
    public partial class AddNewTaskView : Form, IAddNewTaskView
    {
        AddNewTaskViewPresenter presenter;

        public AddNewTaskView()
        {
            InitializeComponent();
            presenter = new AddNewTaskViewPresenter(this);
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

            set
            {
                dateTimePickerDeadline.Value = DateTime.Now;
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
                textFieldName.Text = "";
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
                textFieldDescription.Text = "";
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
                textFieldProgress.Text = "";
            }
        }

        public ComboBox Status
        {
            get
            {
                return comboBoxStatus;
            }

            set
            {
                comboBoxStatus.Text = null;
            }
        }

        public ComboBox User
        {
            get
            {
                return comboBoxUser;
            }

            set
            {
                comboBoxUser.Text = null;
            }
        }

        public ComboBox Project
        {
            get
            {
                return comboBoxProject;
            }

            set
            {
                comboBoxProject.Text = null;
            }
        }

        public void showMessage(string message)
        {
            MessageBox.Show(message);
        }


        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.initProgress();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            presenter.addNewTask();
        }
    }
}
