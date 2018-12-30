using Project_Management_System.Models;
using Project_Management_System.Models.Dao;
using Project_Management_System.Models.Dao.Dao_Implementation;
using Project_Management_System.Views.Administrator.Delete_Views;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Presenters
{
    /// <summary>Administrator's project presenter that contains functions for deleting a project from a database.</summary>
    class DeleteProjectViewPresenter
    {
        private string selectedListItem;
        private ProjectDao projectDao = new ProjectDaoImpl(new Sql());
        private UserDao userDao = new UserDaoImpl(new Sql());
        private IDeleteProjectView view;

        public DeleteProjectViewPresenter(IDeleteProjectView view)
        {
            this.view = view;
        }

        /// <summary>Deletes a project from a database.</summary>
        public void deleteProject()
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
                DialogResult dialogResult = MessageBox.Show("Are you sure, delete project by code: " + projectDao.getProjectForCode(selectedListItem).Name, "Delete this project?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = database.Projects.SingleOrDefault(i => i.Code == selectedListItem);
                    database.Projects.Remove(query);
                    try
                    {
                        database.SaveChanges();
                        view.List.SelectedItems[0].Remove();
                    } catch (DbUpdateException)
                    {
                        view.showMessage("Project deletig failed. Project still have tasks!");
                        return;
                    }
                    view.showMessage("Project successfully deleted!");
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
    }
}
