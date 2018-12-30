using Project_Management_System.Views;
using Project_Management_System.Views.Administrator;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Presenters
{
    /// <summary>Initializes secondary menu views.</summary>
    class AdministratorViewPresenter
    {
        private IAdministratorView view;

        public AdministratorViewPresenter(IAdministratorView view)
        {
            this.view = view;
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
            AdministratorAddMenuView addMenuView = new AdministratorAddMenuView(view.panelMain);
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
            AdministratorModifyMenuView modifyMenu = new AdministratorModifyMenuView(view.panelMain);
            modifyMenu.TopLevel = false;
            view.panelAddMenu.Controls.Clear();
            view.panelAddMenu.Controls.Add(modifyMenu);
            modifyMenu.Show();
            view.panelMain.Controls.Clear();
        }

        /// <summary>
        ///   <para>Initializes delete menu view.</para>
        /// </summary>
        public void initDeleteMenuView()
        {
            AdministratorDeleteMenuView deleteMenu = new AdministratorDeleteMenuView(view.panelMain);
            deleteMenu.TopLevel = false;
            view.panelAddMenu.Controls.Clear();
            view.panelAddMenu.Controls.Add(deleteMenu);
            deleteMenu.Show();
            view.panelMain.Controls.Clear();
        }

        /// <summary>
        ///   <para>Initializes view menu view.</para>
        /// </summary>
        public void initViewMenuView()
        {
            AdministratorViewMenuView viewMenu = new AdministratorViewMenuView(view.panelMain);
            viewMenu.TopLevel = false;
            view.panelAddMenu.Controls.Clear();
            view.panelAddMenu.Controls.Add(viewMenu);
            viewMenu.Show();
            view.panelMain.Controls.Clear();
        }
    }
}
