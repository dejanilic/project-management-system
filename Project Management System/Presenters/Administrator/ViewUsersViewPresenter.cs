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
    /// <summary>Administrator's view presenter that contains functions for viewing users from a database.</summary>
    class ViewUsersViewPresenter
    {
        private UserDao userDao = new UserDaoImpl(new Sql());
        private IViewUsersView view;

        public ViewUsersViewPresenter(IViewUsersView view)
        {
            this.view = view;
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
            initRoles();
        }

        /// <summary>Filters a list of users for a given criteria.</summary>
        public void filter()
        {
            view.List.Items.Clear();
            List<User> users = filterFields();
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

        /// <summary>Resets ListView items.</summary>
        public void reset()
        {
            view.List.Items.Clear();
            initList();
            view.Role.SelectedItem = null;
        }

        /// <summary>Initializes a ComboBox list of Roles.</summary>
        private void initRoles()
        {
            view.Role.Items.Add("Administrator");
            view.Role.Items.Add("ProjectManager");
            view.Role.Items.Add("Developer");
        }

        /// <summary>Returns a list of filtered users.</summary>
        private List<User> filterFields()
        {
            List<User> users = userDao.getUsers();
            if (!view.Role.Text.Equals(""))
            {
                Position position;
                Enum.TryParse(view.Role.Text, out position);
                users = users.Where(user => user.RoleId.Equals((int)position)).ToList();
            }
            return users;
        }
    }
}
