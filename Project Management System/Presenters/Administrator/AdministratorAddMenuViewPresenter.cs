using Project_Management_System.Views.Administrator.Add_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Presenters
{
    /// <summary>Initializes administrator's add menu views.</summary>
    class AdministratorAddMenuViewPresenter
    {
        private IAdministratorAddMenuView view;

        public AdministratorAddMenuViewPresenter(IAdministratorAddMenuView view)
        {
            this.view = view;
        }

        /// <summary>
        ///   <para>Initializes add new project view.</para>
        /// </summary>
        public void initAddNewProjectView()
        {
            AddNewProjectView addTaskView = new AddNewProjectView();
            addTaskView.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(addTaskView);
            addTaskView.Show();
        }

        /// <summary>
        ///   <para>Initializes add new task view.</para>
        /// </summary>
        internal void initAddNewTaskView()
        {
            AddNewTaskView addTaskView = new AddNewTaskView();
            addTaskView.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(addTaskView);
            addTaskView.Show();
        }

        /// <summary>
        ///   <para>Initializes add new user view.</para>
        /// </summary>
        internal void initAddNewUserView()
        {
            AddNewUserView addUserView = new AddNewUserView();
            addUserView.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(addUserView);
            addUserView.Show();
        }
    }
}
