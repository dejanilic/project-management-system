using Project_Management_System.Models;
using Project_Management_System.Models.Dao;
using Project_Management_System.Models.Dao.Dao_Implementation;
using Project_Management_System.Views.Administrator.View_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Presenters
{
    /// <summary>Administrator's view presenter that contains functions for viewing a projects from a database.</summary>
    class ViewProjectsViewPresenter
    {
        private ProjectDao projectDao = new ProjectDaoImpl(new Sql());
        private UserDao userDao = new UserDaoImpl(new Sql());
        private IViewProjectsView view;

        public ViewProjectsViewPresenter(IViewProjectsView view)
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
                item.SubItems.Add(user.Name + " " + user.Surname + " " + user.Username);
                view.List.Items.Add(item);
                if (!view.User.Items.Contains(user.Name + " " + user.Surname + " " + user.Username))
                    view.User.Items.Add(user.Name + " " + user.Surname + " " + user.Username);
            }
        }

        /// <summary>Filters a list of projects for a given criteria.</summary>
        public void filter()
        {
            view.List.Items.Clear();
            List<Project> projects = filterFields();
            User user = new User();
            foreach (Project project in projects)
            {
                ListViewItem item = new ListViewItem(project.Code);
                user = userDao.getUserForId(project.UserId);
                item.SubItems.Add(project.Name);
                item.SubItems.Add(user.Name + " " + user.Surname + " " + user.Username);
                view.List.Items.Add(item);
            }
        }

        /// <summary>Resets ListView items.</summary>
        public void reset()
        {
            view.List.Items.Clear();
            initList();
            view.User.SelectedItem = null;
        }

        /// <summary>Returns a list of filtered projects.</summary>
        private List<Project> filterFields()
        {
            List<Project> projects = projectDao.getProjects();
            if (!view.User.Text.Equals(""))
                projects = projects.Where(project => project.UserId.Equals(userDao.getUserForUsername(Util.split(view.User.Text)).UserId)).ToList();
            return projects;
        }
    }
}
