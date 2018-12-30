using Project_Management_System.Views.Project_Manager.View_Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Presenters.Project_Manager
{
    /// <summary>Initializes Project Manager's view menu views.</summary>
    class ProjectManagerViewMenuViewPresenter
    {
        private int userid;
        private IProjectManagerViewMenuView view;

        public ProjectManagerViewMenuViewPresenter(IProjectManagerViewMenuView view, int userid)
        {
            this.view = view;
            this.userid = userid;
        }

        /// <summary>
        ///   <para>Initializes view project view.</para>
        /// </summary>
        public void initViewProjectsView()
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
        public void initViewTasksView()
        {
            ViewTasksView viewTasks = new ViewTasksView(userid);
            viewTasks.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(viewTasks);
            viewTasks.Show();
        }
    }
}
