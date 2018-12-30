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
    public partial class ModifyTaskView : Form, IModifyTaskView
    {
        ModifyTaskViewPresenter presenter;

        public ModifyTaskView()
        {
            InitializeComponent();
            presenter = new ModifyTaskViewPresenter(this);
            presenter.initList();
            presenter.initStatus();
            presenter.initUsers();
            presenter.initProjects();
            Util.expandListViewHeader(List);
        }

        public DateTimePicker Deadline
        {
            get
            {
                return dateTimePickerDeadline;
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

        public ListView List
        {
            get
            {
                return listViewTasks;
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

        public ComboBox Status
        {
            get
            {
                return comboBoxStatus;
            }

            set
            {
                comboBoxStatus = null;
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
                comboBoxUser = null;
            }
        }

        public void showMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            presenter.modifyTask();
            listViewTasks.Items.Clear();
            new ModifyTaskViewPresenter(this).initList();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.initProgress();
        }
    }
}
