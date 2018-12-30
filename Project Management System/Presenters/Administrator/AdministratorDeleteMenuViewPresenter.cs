using Project_Management_System.Views.Administrator.Delete_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Presenters
{
    /// <summary>Initializes administrator's delete menu views.</summary>
    class AdministratorDeleteMenuViewPresenter
    {
        private IAdministratorDeleteMenuView view;

        public AdministratorDeleteMenuViewPresenter(IAdministratorDeleteMenuView view)
        {
            this.view = view;
        }

        /// <summary>
        ///   <para>Initializes delete project view.</para>
        /// </summary>
        public void initDeleteProjectView()
        {
            DeleteProjectView deletePojectView = new DeleteProjectView();
            deletePojectView.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(deletePojectView);
            deletePojectView.Show();
        }

        /// <summary>
        ///   <para>Initializes delete task view.</para>
        /// </summary>
        public void initDeleteTaskView()
        {
            DeleteTaskView deleteTaskView = new DeleteTaskView();
            deleteTaskView.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(deleteTaskView);
            deleteTaskView.Show();
        }

        /// <summary>
        ///   <para>Initializes delete user view.</para>
        /// </summary>
        public void initDeleteUserView()
        {
            DeleteUserView deleteUserView = new DeleteUserView();
            deleteUserView.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(deleteUserView);
            deleteUserView.Show();
        }
    }
}
