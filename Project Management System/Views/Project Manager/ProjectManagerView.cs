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

namespace Project_Management_System.Views.Project_Manager
{
    public partial class ProjectManagerView : MaterialSkin.Controls.MaterialForm, IProjectManagerView
    {
        ProjectManagerViewPresenter presenter;

        public ProjectManagerView(int userid)
        {
            InitializeComponent();
            presenter = new ProjectManagerViewPresenter(this, userid);
            presenter.initPanelsBackColor();
        }

        Panel IProjectManagerView.panelAddMenu
        {
            get
            {
                return panelAddMenu;
            }
        }

        Panel IProjectManagerView.panelDivider
        {
            get
            {
                return panelDivider;
            }
        }

        Panel IProjectManagerView.panelLeft
        {
            get
            {
                return panelLeft;
            }
        }

        Panel IProjectManagerView.panelLeftTop
        {
            get
            {
                return panelLeftTop;
            }
        }

        Panel IProjectManagerView.panelMain
        {
            get
            {
                return panelMain;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            presenter.initAddMenuView();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            presenter.initModifyMenuView();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            presenter.initViewMenuView();
        }
    }
}
