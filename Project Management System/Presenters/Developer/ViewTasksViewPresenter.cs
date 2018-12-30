using Project_Management_System.Models;
using Project_Management_System.Models.Dao;
using Project_Management_System.Models.Dao.Dao_Implementation;
using Project_Management_System.Views.Developer.View_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Management_System.Presenters.Developer
{
    /// <summary>Developer's view presenter that contains functions for viewing tasks from a database.</summary>
    class ViewTasksViewPresenter
    {
        private int userid;
        private TaskDao taskDao = new TaskDaoImpl();
        private ProjectDao projectDao = new ProjectDaoImpl(new Sql());
        private UserDao userDao = new UserDaoImpl(new Sql());
        private IViewTasksView view;

        public ViewTasksViewPresenter(IViewTasksView view, int userid)
        {
            this.view = view;
            this.userid = userid;
        }

        /// <summary>Initializes a list of tasks.</summary>
        public void initList()
        {
            List<Task> tasks = taskDao.getTasks()
                .Where(task => task.UserId == userid || task.UserId == null)
                .ToList();
            foreach (Task task in tasks)
            {
                ListViewItem item = new ListViewItem(task.TaskId.ToString());
                item.SubItems.Add(task.Name);
                item.SubItems.Add(task.Status.ToString());
                item.SubItems.Add(task.Progress);
                item.SubItems.Add(task.Deadline);
                item.SubItems.Add(task.Description);
                try
                {
                    item.SubItems.Add(userDao.getUsersWithoutAdmin()
                        .Where(user => user.UserId == task.UserId).FirstOrDefault()
                        .Name + " " +
                    userDao.getUsersWithoutAdmin()
                    .Where(user => user.UserId == task.UserId)
                    .FirstOrDefault()
                    .Surname);
                }
                catch (Exception e)
                {
                    item.SubItems.Add("");
                }
                try
                {
                    item.SubItems.Add(projectDao.getProjects()
                        .Where(project => project.ProjectId == task.ProjectId)
                        .FirstOrDefault()
                        .Name);
                }
                catch (Exception e)
                {
                    item.SubItems.Add("");
                }
                view.List.Items.Add(item);
            }
        }
    }
}
