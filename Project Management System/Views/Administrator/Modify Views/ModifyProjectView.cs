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
    public partial class ModifyProjectView : Form, IModifyProjectView
    {
        ModifyProjectViewPresenter presenter;

        public ModifyProjectView()
        {
            InitializeComponent();
            presenter = new ModifyProjectViewPresenter(this);
            presenter.initList();
            presenter.initProjectManagers();
            Util.expandListViewHeader(List);
        }

        public ListView List
        {
            get
            {
                return listViewProjects;
            }
        }

        public ComboBox User
        {
            get
            {
                return comboBoxProjectManager;
            }

            set
            {
                comboBoxProjectManager = value;
            }
        }

        string IModifyProjectView.Code
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

        string IModifyProjectView.Name
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            presenter.modifyProject();
            listViewProjects.Items.Clear();
            new ModifyProjectViewPresenter(this).initList();
        }
    }
}
