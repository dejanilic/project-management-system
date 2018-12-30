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

namespace Project_Management_System.Views
{
    public partial class AdministratorView : MaterialSkin.Controls.MaterialForm, IAdministratorView
    {
        AdministratorViewPresenter presenter;

        public AdministratorView()
        {
            InitializeComponent();
            presenter = new AdministratorViewPresenter(this);
            presenter.initPanelsBackColor();
        }

        Panel IAdministratorView.panelAddMenu
        {
            get
            {
                return panelAddMenu;
            }
        }

        Panel IAdministratorView.panelDivider
        {
            get
            {
                return panelDivider;
            }
        }

        Panel IAdministratorView.panelLeft
        {
            get
            {
                return panelLeft;
            }
        }

        Panel IAdministratorView.panelLeftTop
        {
            get
            {
                return panelLeftTop;
            }
        }

        Panel IAdministratorView.panelMain
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            presenter.initDeleteMenuView();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            presenter.initViewMenuView();
        }
    }
}
