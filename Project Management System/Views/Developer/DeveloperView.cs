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

namespace Project_Management_System.Views.Developer
{
    public partial class DeveloperView : MaterialSkin.Controls.MaterialForm, IDeveloperView
    {
        DeveloperViewPresenter presenter;

        public DeveloperView(int userId)
        {
            InitializeComponent();
            presenter = new DeveloperViewPresenter(this, userId);
            presenter.initPanelsBackColor();
        }

        Panel IDeveloperView.panelAddMenu
        {
            get
            {
                return panelAddMenu;
            }
        }

        Panel IDeveloperView.panelDivider
        {
            get
            {
                return panelDivider;
            }
        }

        Panel IDeveloperView.panelLeft
        {
            get
            {
                return panelLeft;
            }
        }

        Panel IDeveloperView.panelLeftTop
        {
            get
            {
                return panelLeftTop;
            }
        }

        Panel IDeveloperView.panelMain
        {
            get
            {
                return panelMain;
            }
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
