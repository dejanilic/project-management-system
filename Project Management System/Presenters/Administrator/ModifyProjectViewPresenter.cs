using Project_Management_System.Models;
using Project_Management_System.Models.Dao;
using Project_Management_System.Models.Dao.Dao_Implementation;
using Project_Management_System.Views.Administrator.Modify_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Presenters
{
    /// <summary>Administrator's project presenter that contains functions for modifying a project from a database.</summary>
    class ModifyProjectViewPresenter
    {
        private string selectedListItem;
        private ProjectDao projectDao = new ProjectDaoImpl(new Sql());
        private UserDao userDao = new UserDaoImpl(new Sql());
        private IModifyProjectView view;

        public ModifyProjectViewPresenter(IModifyProjectView view)
        {
            this.view = view;
        }

        /// <summary>Modifies a project from a database.</summary>
        public void modifyProject()
        {
            if (view.List.SelectedIndices.Count <= 0)
            {
                view.showMessage("Select a project!");
                return;
            }
            else
                selectedListItem = view.List.SelectedItems[0].Text;

            using (var database = new Sql())
            {
                var query = database.Projects.SingleOrDefault(i => i.Code == selectedListItem);
                if (query != null)
                {
                    if (projectDao.exists(view.Code))
                    {
                        view.showMessage("Project already exists!");
                        view.Code = "";
                        return;
                    }
                    if (!view.Name.Equals(""))
                        query.Name = view.Name;
                    if (!view.Code.Equals(""))
                        query.Code = view.Code;
                    if (!view.User.Text.Equals(""))
                    {
                        User user = userDao.getUserForUsername(Util.split(view.User.Text));
                        if (user != null)
                            query.UserId = user.UserId;
                    }
                    database.SaveChanges();
                    resetFields();
                    view.showMessage("Project successfully saved!");
                }
            }
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
                item.SubItems.Add(user.Name + " " + user.Surname);
                view.List.Items.Add(item);
            }
        }

        /// <summary>Initializes a list of Project Managers.</summary>
        public void initProjectManagers()
        {
            List<User> users = projectDao.getProjectManagers();
            foreach(User u in users)
            {
                view.User.Items.Add(u.Name + " " + u.Surname + " " + u.Username);
            }
        }

        /// <summary>Resets input fields.</summary>
        private void resetFields()
        {
            view.Name = "";
            view.Code = "";
            view.User.SelectedItem = null;
        }
    }
}
