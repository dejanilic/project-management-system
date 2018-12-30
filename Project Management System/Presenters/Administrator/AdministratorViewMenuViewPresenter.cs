using Project_Management_System.Views.Administrator.View_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Presenters
{
    /// <summary>Initializes administrator's view menu views.</summary>
    class AdministratorViewMenuViewPresenter
    {
        private IAdministratorViewMenuView view;

        public AdministratorViewMenuViewPresenter(IAdministratorViewMenuView view)
        {
            this.view = view;
        }

        /// <summary>
        ///   <para>Initializes view project view.</para>
        /// </summary>
        public void viewProjects()
        {
            ViewProjectsView viewProjects = new ViewProjectsView();
            viewProjects.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(viewProjects);
            viewProjects.Show();
        }

        /// <summary>
        ///   <para>Initializes view task view.</para>
        /// </summary>
        public void viewTasks()
        {
            ViewTasksView viewTasks = new ViewTasksView();
            viewTasks.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(viewTasks);
            viewTasks.Show();
        }

        /// <summary>
        ///   <para>Initializes view user view.</para>
        /// </summary>
        public void viewUsers()
        {
            ViewUsersView viewUsers = new ViewUsersView();
            viewUsers.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(viewUsers);
            viewUsers.Show();
        }
    }
}
