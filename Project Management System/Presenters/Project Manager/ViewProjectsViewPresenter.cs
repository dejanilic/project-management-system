using Project_Management_System.Models;
using Project_Management_System.Models.Dao;
using Project_Management_System.Models.Dao.Dao_Implementation;
using Project_Management_System.Views.Project_Manager.View_Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Management_System.Presenters.Project_Manager
{
    /// <summary>Project Manager's view presenter that contains functions for viewing a projects from a database.</summary>
    class ViewProjectsViewPresenter
    {
        private TaskDao taskDao = new TaskDaoImpl();
        private ProjectDao projectDao = new ProjectDaoImpl(new Sql());
        private UserDao userDao = new UserDaoImpl(new Sql());
        private IViewMenuView view;

        public ViewProjectsViewPresenter(IViewMenuView view)
        {
            this.view = view;
        }

        /// <summary>Initializes a list of projects.</summary>
        public void initList()
        {
            List<Project> projects = projectDao.getProjects();
            User user = new User();
            foreach (Project project in projects)
            {
                ListViewItem item = new ListViewItem(project.Code);
                user = userDao.getUserForId(project.UserId);
                item.SubItems.Add(project.Name);
                item.SubItems.Add(formatProgress(project.ProjectId));
                view.List.Items.Add(item);
            }
        }

        /// <summary>Returns formatted progress based on tasks of a project, for a given project id.</summary>
        /// <param name="id">Project id</param>
        private string formatProgress(int id)
        {
            List<Task> list = taskDao.getTasksForProjectId(id);
            double sum = 0;
            foreach(Task item in list)
            {
                sum += Util.parseString(item.Progress);
            }
            Double formatted = Math.Round(((sum / (list.Count * 100)) * 100), 2);
            return formatted.ToString();
        }
    }
}
