using Project_Management_System.Views.Project_Manager.Add_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Presenters.Project_Manager
{
    /// <summary>Initializes Project Manager's add menu views.</summary>
    class ProjectManagerAddMenuViewPresenter
    {
        private int userid;
        private IProjectManagerAddMenuView view;

        public ProjectManagerAddMenuViewPresenter(IProjectManagerAddMenuView view, int userid)
        {
            this.view = view;
            this.userid = userid;
        }

        /// <summary>
        ///   <para>Initializes add new project view.</para>
        /// </summary>
        public void initAddNewProjectView()
        {
            AddNewProjectView addNewProject = new AddNewProjectView(userid);
            addNewProject.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(addNewProject);
            addNewProject.Show();
        }

        /// <summary>
        ///   <para>Initializes add new task view.</para>
        /// </summary>
        public void initAddNewTaskView()
        {
            AddNewTaskView addNewTask = new AddNewTaskView(); 
            addNewTask.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(addNewTask);
            addNewTask.Show();
        }
    }
}
