using Project_Management_System.Views.Developer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Presenters.Developer
{
    /// <summary>Initializes secondary menu views.</summary>
    class DeveloperViewPresenter
    {
        private int userid;
        private IDeveloperView view;

        public DeveloperViewPresenter(IDeveloperView view, int userid)
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
        ///   <para>Initializes modify menu view.</para>
        /// </summary>
        public void initModifyMenuView()
        {
            DeveloperModifyMenuView modifyMenu = new DeveloperModifyMenuView(view.panelMain, userid);
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
            DeveloperViewMenuView viewMenu = new DeveloperViewMenuView(view.panelMain, userid);
            viewMenu.TopLevel = false;
            view.panelAddMenu.Controls.Clear();
            view.panelAddMenu.Controls.Add(viewMenu);
            viewMenu.Show();
            view.panelMain.Controls.Clear();
        }
    }
}
