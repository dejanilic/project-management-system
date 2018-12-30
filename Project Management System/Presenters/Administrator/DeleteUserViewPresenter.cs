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
    /// <summary>Administrator's user presenter that contains functions for deleting an user from a database.</summary>
    class DeleteUserViewPresenter
    {
        private string selectedListItem;
        private UserDao userDao = new UserDaoImpl(new Sql());
        private IDeleteUserView view;

        public DeleteUserViewPresenter(IDeleteUserView view)
        {
            this.view = view;
        }

        /// <summary>Deletes an user from a database.</summary>
        public void deleteUser()
        {
            if (view.List.SelectedIndices.Count <= 0)
            {
                view.showMessage("Select a user!");
                return;
            }
            else
                selectedListItem = view.List.SelectedItems[0].Text;

            using (var database = new Sql())
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete this user?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = database.Users.SingleOrDefault(i => i.Username == selectedListItem);
                    database.Users.Remove(query);
                    try
                    {
                        database.SaveChanges();
                        view.List.SelectedItems[0].Remove();
                    }
                    catch (DbUpdateException e)
                    {
                        view.showMessage("User deletig failed! User have tasks or projects!");
                        return;
                    }
                    view.showMessage("User successfully deleted!");
                }
            }
        }

        /// <summary>Initializes a list of users.</summary>
        public void initList()
        {
            List<User> users = userDao.getUsers();
            foreach (User user in users)
            {
                ListViewItem item = new ListViewItem(user.Username);
                item.SubItems.Add(user.Password);
                item.SubItems.Add(user.Name);
                item.SubItems.Add(user.Surname);
                item.SubItems.Add(user.Email);
                item.SubItems.Add(((Position)user.RoleId).ToString());
                view.List.Items.Add(item);
            }
        }
    }
}
