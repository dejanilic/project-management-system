using Project_Management_System.Models;
using Project_Management_System.Models.Dao;
using Project_Management_System.Models.Dao.Dao_Implementation;
using Project_Management_System.Views.Administrator.Delete_Views;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Management_System.Presenters
{
    /// <summary>Administrator's task presenter that contains functions for deleting a task from a database.</summary>
    class DeleteTaskViewPresenter
    {
        private int selectedListItem;
        private TaskDao taskDao = new TaskDaoImpl();
        private ProjectDao projectDao = new ProjectDaoImpl(new Sql());
        private UserDao userDao = new UserDaoImpl(new Sql());
        private IDeleteTaskView view;

        public DeleteTaskViewPresenter(IDeleteTaskView view)
        {
            this.view = view;
        }

        /// <summary>Deletes a task from a database.</summary>
        public void deleteTask()
        {
            if (view.List.SelectedIndices.Count <= 0)
            {
                view.showMessage("Select a task!");
                return;
            }
            else
                selectedListItem = Util.parseString(view.List.SelectedItems[0].Text);

            using (var database = new Sql())
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete this task?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = database.Tasks.SingleOrDefault(i => i.TaskId == selectedListItem);
                    database.Tasks.Remove(query);
                    database.SaveChanges();
                    view.List.SelectedItems[0].Remove();
                    view.showMessage("Task successfully deleted!");
                }
            }
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
                    item.SubItems.Add(userDao.getUsersWithoutAdmin()
                        .Where(user => user.UserId == task.UserId)
                        .FirstOrDefault()
                        .Name + " " +
                    userDao.getUsersWithoutAdmin()
                        .Where(user => user.UserId == task.UserId)
                        .FirstOrDefault()
                        .Surname);
                }
                catch (Exception)
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
                catch (Exception)
                {
                    item.SubItems.Add("");
                }
                view.List.Items.Add(item);
            }
        }
    }
}
