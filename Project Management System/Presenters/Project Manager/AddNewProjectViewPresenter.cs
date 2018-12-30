using Project_Management_System.Models;
using Project_Management_System.Models.Dao;
using Project_Management_System.Models.Dao.Dao_Implementation;
using Project_Management_System.Views.Project_Manager.Add_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Presenters.Project_Manager
{
    /// <summary>Project Manager's project presenter that contains functions for adding a project to a database.</summary>
    class AddNewProjectViewPresenter
    {
        private int userid;
        private ProjectDao projectDao = new ProjectDaoImpl(new Sql());
        private UserDao userDao = new UserDaoImpl(new Sql());
        private IAddNewProjectView view;

        public AddNewProjectViewPresenter(IAddNewProjectView view, int userid)
        {
            this.view = view;
            this.userid = userid;
        }

        /// <summary>Adds a new project to a database.</summary>
        public void addNewProject()
        {
            if (view.Name.Equals("") || view.Code.Equals("")
                || view.Users.Text.Equals(""))
            {
                view.showMessage("Fields can't be empty!");
            }
            else
            {
                if (!projectDao.exists(view.Code))
                {
                    using (var database = new Sql())
                    {
                        User user = userDao.getUserForUsername(Util.split(view.Users.Text));
                        Project project = new Project();
                        project.Name = view.Name;
                        project.Code = view.Code;
                        database.Projects.Add(project);
                        database.Users.Attach(user);
                        project.User = user;
                        database.SaveChanges();
                        resetFields();
                        view.showMessage("Project successfully saved!");
                    }
                }
                else
                {
                    view.showMessage("Project already exists");
                }
            }
        }

        /// <summary>Initializes a ComboBox list of users.</summary>
        public void initUsers()
        {
            User user = userDao.getUserForId(userid);
            view.Users.Items.Add(user.Name + " " + user.Surname + " " + user.Username);
        }

        /// <summary>Resets input fields.</summary>
        private void resetFields()
        {
            view.Name = "";
            view.Code = "";
            view.Users.SelectedItem = null;
        }
    }
}
