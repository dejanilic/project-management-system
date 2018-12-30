using Project_Management_System.Presenters.Developer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Developer.Modify
{
    public partial class ModifyTaskView : Form, IModifyTaskView
    {
        int userId;
        ModifyTaskViewPresenter presenter;

        public ModifyTaskView(int userId)
        {
            InitializeComponent();
            presenter = new ModifyTaskViewPresenter(this, userId);
            this.userId = userId;
            presenter.initList();
            presenter.initStatus();
            Util.expandListViewHeader(List);
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

            set
            {
                comboBoxStatus = null;
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
            new ModifyTaskViewPresenter(this, userId).initList(); ;
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.initProgress();
        }
    }
}
