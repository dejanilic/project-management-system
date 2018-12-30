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
    class AddNewUserViewPresenter
    {
        private UserDao userDao = new UserDaoImpl(new Sql());
        private RoleDao roleDao = new RoleDaoImpl();
        private IAddNewUserView view;

        public AddNewUserViewPresenter(IAddNewUserView view)
        {
            this.view = view;
        }

        /// <summary>Adds a new user to a database.</summary>
        public void addNewUser()
        {
            if (view.Username.Equals("") || view.Password.Equals("")
                || view.Name.Equals("") || view.Surname.Equals("")
                || view.Email.Equals("") || view.Role.Text.Equals(""))
            {
                view.showMessage("Fields can't be empty!");
            } else
            {
                if (!userDao.exists(view.Username))
                {
                    using (var database = new Sql())
                    {
                        Role role = roleDao.getRole(view.Role.Text);
                        User user = new User();
                        Position position;
                        Enum.TryParse(view.Role.Text, out position);
                        role.Position = position;
                        user.Username = view.Username;
                        user.Password = view.Password;
                        user.Name = view.Name;
                        user.Surname = view.Surname;
                        user.Email = view.Email;
                        database.Users.Add(user);
                        database.Roles.Attach(role);
                        user.Role = role;
                        database.SaveChanges();
                        resetFields();
                        view.showMessage("User successfully saved!");
                    }
                }
                else
                {
                    view.showMessage("User already exists!");
                    view.Username = "";
                }
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
