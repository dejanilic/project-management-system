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
    /// <summary>Administrator's user presenter that contains functions for modifying an user from a database.</summary>
    class ModifyUserViewPresenter
    {
        private string selectedListItem;
        private RoleDao roleDao = new RoleDaoImpl();
        private UserDao userDao = new UserDaoImpl(new Sql());
        private IModifyUserView view;

        public ModifyUserViewPresenter(IModifyUserView view)
        {
            this.view = view;
        }

        /// <summary>Modifies an user from a database.</summary>
        public void modifyUser()
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
                var query = database.Users.SingleOrDefault(i => i.Username == selectedListItem);
                if (query != null)
                {
                    if (userDao.exists(view.Username))
                    {
                        view.showMessage("User already exist!");
                        return;
                    }
                    if (!view.Username.Equals(""))
                        query.Username = view.Username;
                    if (!view.Password.Equals(""))
                        query.Password = view.Password;
                    if (!view.Name.Equals(""))
                        query.Name = view.Name;
                    if (!view.Surname.Equals(""))
                        query.Surname = view.Surname;
                    if (!view.Email.Equals(""))
                        query.Email = view.Email;
                    if (!view.Role.Text.Equals(""))
                    {
                        Role role = roleDao.getRole(view.Role.Text);
                        database.Roles.Attach(role);
                        query.Role = role;
                    }
                    database.SaveChanges();
                    resetFields();
                    view.showMessage("User successfully saved!");
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
                //item.SubItems.Add(user.Password);
                item.SubItems.Add(user.Name);
                item.SubItems.Add(user.Surname);
                item.SubItems.Add(user.Email);
                item.SubItems.Add(((Position)user.RoleId).ToString());
                view.List.Items.Add(item);
            }
        }

        /// <summary>Initializes a ComboBox list of Roles.</summary>
        public void initRoles()
        {
            view.Role.Items.Add("Administrator");
            view.Role.Items.Add("ProjectManager");
            view.Role.Items.Add("Developer");
        }

        /// <summary>Resets input fields.</summary>
        private void resetFields()
        {
            view.Name = "";
            view.Email = "";
            view.Password = "";
            view.Role.SelectedItem = null;
            view.Surname = "";
            view.Username = "";
        }
    }
}
