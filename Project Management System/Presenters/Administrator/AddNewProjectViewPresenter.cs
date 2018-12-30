using Project_Management_System.Models;
using Project_Management_System.Models.Dao;
using Project_Management_System.Models.Dao.Dao_Implementation;
using Project_Management_System.Views.Administrator.Add_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Presenters
{
    /// <summary>Administrator's project presenter that contains functions for adding a project to a database.</summary>
    class AddNewProjectViewPresenter
    {
        private ProjectDao projectDao = new ProjectDaoImpl(new Sql());
        private UserDao userDao = new UserDaoImpl(new Sql());
        private IAddNewProjectView view;
        
        public AddNewProjectViewPresenter(IAddNewProjectView view)
        {
            this.view = view;
        }

        /// <summary>Adds a new project to a database.</summary>
        public void addNewProject()
        {
            if (view.Name.Equals("") || view.Code.Equals("") 
                || view.cBox.Text.Equals(""))
            {
                view.showMessage("Fields can't be empty!");
            }
            else
            {
                if (!projectDao.exists(view.Code))
                {
                    using (var database = new Sql())
                    {
                        User user = userDao.getUserForUsername(Util.split(view.cBox.Text));
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
                    view.Code = "";
                }
            }
        }

        /// <summary>Initializes a ComboBox list of Project Managers.</summary>
        public void initCBox()
        {
            List<User> users = projectDao.getProjectManagers();
            foreach(User user in users)
            {
                view.cBox.Items.Add(user.Name + " " + user.Surname + " " + user.Username);
            }
        }

        /// <summary>Resets input fields.</summary>
        public void resetFields()
        {
            view.Name = "";
            view.Code = "";
            view.cBox.SelectedItem = null;
        }
    }
}
