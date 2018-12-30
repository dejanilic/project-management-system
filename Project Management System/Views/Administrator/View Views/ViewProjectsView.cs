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

namespace Project_Management_System.Views.Administrator.View_Views
{
    public partial class ViewProjectsView : Form, IViewProjectsView
    {
        ViewProjectsViewPresenter presenter;

        public ViewProjectsView()
        {
            InitializeComponent();
            presenter = new ViewProjectsViewPresenter(this);
            presenter.initList();
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
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            presenter.filter();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            presenter.reset();
        }
    }
}
