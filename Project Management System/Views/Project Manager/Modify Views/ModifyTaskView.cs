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

namespace Project_Management_System.Views.Project_Manager.Modify_Views
{
    public partial class ModifyTaskView : Form, IModifyTaskView
    {
        int userid;
        ModifyTaskViewPresenter presenter;

        public ModifyTaskView(int userid)
        {
            InitializeComponent();
            presenter = new ModifyTaskViewPresenter(this, userid);
            this.userid = userid;
            presenter.initList();
            presenter.initStatus();
            presenter.initUsers();
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

        public void showMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            presenter.modifyTask();
            listViewTasks.Items.Clear();
            new ModifyTaskViewPresenter(this, userid).initList();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.initProgress();
        }
    }
}
