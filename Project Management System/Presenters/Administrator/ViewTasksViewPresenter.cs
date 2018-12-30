using Project_Management_System.Models;
using Project_Management_System.Models.Dao;
using Project_Management_System.Models.Dao.Dao_Implementation;
using Project_Management_System.Views.Administrator.View_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Management_System.Presenters
{
    /// <summary>Administrator's view presenter that contains functions for viewing tasks from a database.</summary>
    class ViewTasksViewPresenter
    {
        private TaskDao taskDao = new TaskDaoImpl();
        private ProjectDao projectDao = new ProjectDaoImpl(new Sql());
        private UserDao userDao = new UserDaoImpl(new Sql());
        private IViewTasksView view;

        public ViewTasksViewPresenter(IViewTasksView view)
        {
            this.view = view;
        }

        /// <summary>Initializes a list of tasks.</summary>
        public void initList()
        {
            List<Task> tasks = taskDao.getTasks();
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
                    item.SubItems.Add(userDao.formatFullName(task.UserId));
                }
                catch (Exception)
                {
                    item.SubItems.Add(" ");
                }
                try
                {
                    item.SubItems.Add(projectDao.getProjectNameForId(task.ProjectId));
                }
                catch (Exception)
                {
                    item.SubItems.Add(" ");
                }
                view.List.Items.Add(item);
            }
            initFields(tasks);
        }

        /// <summary>Filters a list of tasks for a given criteria.</summary>
        public void filter()
        {
            view.List.Items.Clear();
            List<Task> tasks = filterFields();
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
                    item.SubItems.Add(userDao.formatFullName(task.UserId));
                }
                catch (Exception)
                {
                    item.SubItems.Add(" ");
                }
                try
                {
                    item.SubItems.Add(projectDao.getProjectNameForId(task.ProjectId));
                }
                catch (Exception)
                {
                    item.SubItems.Add(" ");
                }
                view.List.Items.Add(item);
            }
        }

        /// <summary>Resets ListView items.</summary>
        public void reset()
        {
            view.List.Items.Clear();
            initList();
            resetFields();
        }

        /// <summary>Resets input fields.</summary>
        private void resetFields()
        {
            view.Deadline.SelectedItem = null;
            view.Project.SelectedItem = null;
            view.Status.SelectedItem = null;
            view.User.SelectedItem = null;
        }

        /// <summary>Initializes input fields.</summary>
        private void initFields(List<Task> tasks)
        {
            foreach(Task task in tasks)
            {
                if (!view.Status.Items.Contains(task.Status))
                    view.Status.Items.Add(task.Status);
                if (!view.Deadline.Items.Contains(task.Deadline))
                    view.Deadline.Items.Add(task.Deadline);
                if (task.UserId != null)
                {
                    User user = userDao.getUserForId((int)task.UserId);
                    if (!view.User.Items.Contains(user.Name + " " + user.Surname + " " + user.Username))
                    {
                        view.User.Items.Add(user.Name + " " + user.Surname + " " + user.Username);
                    }
                }
                if (task.ProjectId != null && !view.Project.Items.Contains(projectDao.getProjectNameForId(task.ProjectId)))
                    view.Project.Items.Add(projectDao.getProjectNameForId(task.ProjectId));
            }
        }

        /// <summary>Returns a list of filtered tasks.</summary>
        private List<Task> filterFields()
        {
            List<Task> tasks = taskDao.getTasks();
            if (!view.Status.Text.Equals(""))
                tasks = tasks.Where(task => task.Status.ToString().Equals(view.Status.Text)).ToList();
            if (!view.Deadline.Text.Equals(""))
                tasks = tasks.Where(task => task.Deadline.Equals(view.Deadline.Text)).ToList();
            if (!view.User.Text.Equals(""))
                tasks = tasks.Where(task => task.UserId.Equals(userDao.getUserForUsername(Util.split(view.User.Text)).UserId)).ToList();
            if (!view.Project.Text.Equals(""))
                tasks = tasks.Where(task => task.ProjectId.Equals(projectDao.getProjectIdForName(view.Project.Text).ProjectId)).ToList();
            return tasks;
        }
    }
}
