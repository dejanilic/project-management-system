using Project_Management_System.Models;
using Project_Management_System.Models.Dao;
using Project_Management_System.Models.Dao.Dao_Implementation;
using Project_Management_System.Views.Project_Manager.Modify_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Management_System.Presenters.Project_Manager
{
    /// <summary>Project Manager's task presenter that contains functions for modifying a task from a database.</summary>
    class ModifyTaskViewPresenter
    {
        private int userid;
        private int selectedListItem;
        private TaskDao taskDao = new TaskDaoImpl();
        private ProjectDao projectDao = new ProjectDaoImpl(new Sql());
        private UserDao userDao = new UserDaoImpl(new Sql());
        private IModifyTaskView view;

        public ModifyTaskViewPresenter(IModifyTaskView view, int userid)
        {
            this.view = view;
            this.userid = userid;
        }

        /// <summary>Modifies a task from a database.</summary>
        public void modifyTask()
        {
            if (view.List.SelectedIndices.Count <= 0)
            {
                view.showMessage("Select a task!");
                return;
            }
            else
                selectedListItem = Util.parseString(view.List.SelectedItems[0].Text);
            if (!Util.isInt(view.Progress))
            {
                view.showMessage("Progress must be a number!");
                resetFields();
                return;
            }
            using (var database = new Sql())
            {
                var query = database.Tasks.SingleOrDefault(i => i.TaskId == selectedListItem);
                if (query != null)
                {
                    if (!view.Status.Text.Equals(""))
                    {
                        Status status;
                        Enum.TryParse(view.Status.Text, out status);
                        query.Status = status;
                    }
                    if (!view.Progress.Equals(""))
                        query.Progress = view.Progress;
                    if (!view.Deadline.Equals(""))
                        query.Deadline = view.Deadline.Text;
                    if (!view.Description.Equals(""))
                        query.Description = view.Description;
                    if (!view.User.Text.Equals(""))
                    {
                        User user = userDao.getUserForUsername(Util.split(view.User.Text));
                        if (!userDao.checkDevelopersTasks(view.User.Text, Util.split(view.User.Text)))
                        {
                            database.Users.Attach(user);
                            query.UserId = user.UserId;
                        }
                        else
                        {
                            view.showMessage("User can't have more tha 3 tasks!");
                            return;
                        }
                    }

                    database.SaveChanges();
                    resetFields();
                    view.showMessage("Task successfully saved!");
                }
            }
        }

        /// <summary>Initializes a list of tasks.</summary>
        public void initList()
        {
            List<Task> tasks = taskDao.getTasks()
                .Where(task => task.UserId == userid)
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
                        .Where(user => user.UserId == task.UserId)
                        .FirstOrDefault()
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

        /// <summary>Initializes a list of status.</summary>
        public void initStatus()
        {
            Util.initStatus(view.Status);
        }

        /// <summary>Initializes a list of users.</summary>
        public void initUsers()
        {
            List<User> users = userDao.getUsers().Where(role => role.RoleId == 3).ToList();
            foreach (User user in users)
            {
                view.User.Items.Add(user.Name + " " + user.Surname + " " + user.Username);
            }
        }

        /// <summary>Initializes a TextField based on status input.</summary>
        public void initProgress()
        {
            if (view.Status.Text.Equals("New"))
                view.Progress = "0";
            else if (view.Status.Text.Equals("Finished"))
                view.Progress = "100";
            else
                view.Progress = "";
        }

        /// <summary>Resets input fields.</summary>
        private void resetFields()
        {
            view.Deadline.Value = DateTime.Now;
            view.Description = "";
            view.Progress = "";
            view.Status.SelectedItem = null;
            view.User.SelectedItem = null;
        }
    }
}
