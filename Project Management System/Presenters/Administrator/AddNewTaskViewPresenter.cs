using Project_Management_System.Models;
using Project_Management_System.Models.Dao;
using Project_Management_System.Models.Dao.Dao_Implementation;
using Project_Management_System.Views.Administrator.Add_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Management_System.Presenters
{
    /// <summary>Administrator's task presenter that contains functions for adding a task to a database.</summary>
    class AddNewTaskViewPresenter
    {
        private ProjectDao projectDao = new ProjectDaoImpl(new Sql());
        private UserDao userDao = new UserDaoImpl(new Sql());
        private IAddNewTaskView view;

        public AddNewTaskViewPresenter(IAddNewTaskView view)
        {
            this.view = view;
        }

        /// <summary>Adds a new task to a database.</summary>
        public void addNewTask()
        {
            if (view.Name.Equals("") || view.Status.Text.Equals("")
                || view.Progress.Equals("") || view.Description.Equals(""))
            {
                view.showMessage("Fields can't be empty!");
            } else
            {
                if (userDao.checkDevelopersTasks(view.User.Text, Util.split(view.User.Text)))
                {
                    view.showMessage("User can't have more than 3 tasks!");
                    return;
                }
                if (!Util.isInt(view.Progress))
                {
                    view.showMessage("Progress must be a number!");
                    resetFields();
                    return;
                }
                using (var database = new Sql())
                {
                    Task task = new Task();
                    task.Name = view.Name;
                    Status status;
                    Enum.TryParse(view.Status.Text, out status);
                    task.Status = status;
                    task.Progress = view.Progress;
                    task.Deadline = view.Deadline.Text;
                    task.Description = view.Description;
                    database.Tasks.Add(task);
                    if (!view.User.Text.Equals(""))
                    {
                        User user = userDao.getUserForUsername(Util.split(view.User.Text));
                        database.Users.Attach(user);
                        task.User = user;
                    }
                    if (!view.Project.Text.Equals(""))
                    {
                        Project project = projectDao.getProjectForCode(view.Project.Text);
                        database.Projects.Attach(project);
                        task.Project = project;
                    }
                    if (!view.User.Text.Equals("") && view.Project.Text.Equals(""))
                    {
                        view.showMessage("Can't add an user! Assign project first.");
                        return;
                    }
                    database.SaveChanges();
                    resetFields();
                    view.showMessage("Task successfully saved!");
                }
            }
        }

        /// <summary>Initializes a ComboBox list of status.</summary>
        public void initStatus()
        {
            Util.initStatus(view.Status);
        }

        /// <summary>Initializes a ComboBox list of Project Managers and Developers.</summary>
        public void initUsers()
        {
            List<User> users = userDao.getUsersWithoutAdmin();
            foreach(User user in users)
            {
                view.User.Items.Add(user.Name + " " + user.Surname + " " + user.Username);
            }
        }

        /// <summary>Initializes a ComboBox list of projects.</summary>
        public void initProjects()
        {
            List<Project> projects = projectDao.getProjects();
            foreach(Project project in projects)
            {
                view.Project.Items.Add(project.Code + " " + project.Name);
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
            view.Name = "";
            view.Progress = "";
            view.Project.SelectedItem = null;
            view.Status.SelectedItem = null;
            view.User.SelectedItem = null;
            view.Deadline.Value = DateTime.Now;
            view.Description = "";
        }
    }
}
