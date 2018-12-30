using Project_Management_System.Views.Project_Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Presenters.Project_Manager
{
    /// <summary>Initializes secondary menu views.</summary>
    class ProjectManagerViewPresenter
    {
        private int userid;
        private IProjectManagerView view;

        public ProjectManagerViewPresenter(IProjectManagerView view, int userid)
        {
            this.view = view;
            this.userid = userid;
        }

        /// <summary>
        ///   <para>Initializes panel's back color.</para>
        /// </summary>
        public void initPanelsBackColor()
        {
            view.panelLeftTop.BackColor = Color.FromArgb(55, 71, 79);
            view.panelLeft.BackColor = Color.FromArgb(67, 87, 97);
            view.panelDivider.BackColor = Color.FromArgb(67, 87, 97);
        }

        /// <summary>
        ///   <para>Initializes add menu view.</para>
        /// </summary>
        public void initAddMenuView()
        {
            ProjectManagerAddMenuView addMenuView = new ProjectManagerAddMenuView(view.panelMain, userid);
            addMenuView.TopLevel = false;
            view.panelAddMenu.Controls.Clear();
            view.panelAddMenu.Controls.Add(addMenuView);
            addMenuView.Show();
            view.panelMain.Controls.Clear();
        }

        /// <summary>
        ///   <para>Initializes modify menu view.</para>
        /// </summary>
        public void initModifyMenuView()
        {
            ProjectManagerModifyMenuView modifyMenu = new ProjectManagerModifyMenuView(view.panelMain, userid);
            modifyMenu.TopLevel = false;
            view.panelAddMenu.Controls.Clear();
            view.panelAddMenu.Controls.Add(modifyMenu);
            modifyMenu.Show();
            view.panelMain.Controls.Clear();
        }

        /// <summary>
        ///   <para>Initializes view menu view.</para>
        /// </summary>
        public void initViewMenuView()
        {
            ProjectManagerViewMenuView viewMenu = new ProjectManagerViewMenuView(view.panelMain, userid);
            viewMenu.TopLevel = false;
            view.panelAddMenu.Controls.Clear();
            view.panelAddMenu.Controls.Add(viewMenu);
            viewMenu.Show();
            view.panelMain.Controls.Clear();
        }
    }
}
