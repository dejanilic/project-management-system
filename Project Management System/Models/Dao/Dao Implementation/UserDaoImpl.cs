using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Models.Dao.Dao_Implementation
{
    /// <summary>Implements UserDao interface and defines User related functions for database manipulation.</summary>
    class UserDaoImpl : UserDao
    {
        Sql database;

        public UserDaoImpl(Sql database)
        {
            this.database = database;
        }

        /// <summary>Checks if an user exists.</summary>
        /// <param name="username">
        ///   <para>User's username</para>
        /// </param>
        public bool exists(string username)
        {
            var query = from user in database.Users
                        where user.Username == username
                        select user;
            if (query.Count() > 0) return true;
            return false;
        }

        /// <summary>Checks if an user is valid.</summary>
        /// <param name="username">User's username</param>
        /// <param name="password">User's password</param>
        public bool isValid(string username, string password)
        {
            Sql database = new Sql();
            var users = from user in database.Users
                        where user.Username == username &&
                        user.Password == password
                        select user;
            if (users.Count() > 0) return true;
            return false;
        }

        /// <summary>Returns an user object for a given user id.</summary>
        /// <param name="id">User's id</param>
        public User getUserForId(int id)
        {
            var query = from user in database.Users
                        where user.UserId == id
                        select user;
            return query.FirstOrDefault();
        }

        /// <summary>Returns an user object for a given username.</summary>
        /// <param name="username">User's username</param>
        public User getUserForUsername(string username)
        {
            var query = from user in database.Users
                        where user.Username == username
                        select user;
            return query.FirstOrDefault();
        }

        /// <summary>Returns a list of all users.</summary>
        public List<User> getUsers()
        {
            List<User> list = new List<User>();
            list = (from user in database.Users
                    select user).ToList();
            return list;
        }

        /// <summary>Returns a list of users which role is Project Manager or Developer.</summary>
        public List<User> getUsersWithoutAdmin()
        {
            List<User> list = new List<User>();
            list = (from user in database.Users
                    where user.Role.Id == 2 ||
                    user.Role.Id == 3
                    select user).ToList();
            return list;
        }


        /// <summary>Checks if a developer have three tasks.</summary>
        /// <param name="user">Texfield's input</param>
        /// <param name="splitted">User's username</param>
        public bool checkDevelopersTasks(string user, string splitted)
        {
            User newUser = getUserForUsername(splitted);
            var query = from u in database.Tasks
                        where u.User.Role.Id == 3 &&
                        u.User.Username.Equals(newUser.Username)
                        select u;
            if (user.Equals(""))
                return false;
            if (query.Count() == 3) return true;
            return false;
        }

        /// <summary>Returns a formatted user full name.</summary>
        /// <param name="userid">User's id</param>
        public string formatFullName(int? userid)
        {
            UserDao userDao = new UserDaoImpl(new Sql());
            var query = userDao.getUsersWithoutAdmin().
                        Where(user => user.UserId == userid)
                        .FirstOrDefault()
                        .Name + " " +
                    userDao.getUsersWithoutAdmin()
                    .Where(user => user.UserId == userid)
                    .FirstOrDefault()
                    .Surname;
            return query.ToString();
        }

        /// <summary>Returns a user id for a given full name.</summary>
        /// <param name="name">User's first name</param>
        /// <param name="surname">User's last name</param>
        public int getUserIdForFullName(string name, string surname)
        {
            var query = from user in database.Users
                        where user.Name == name && user.Surname == surname
                        select user.UserId;
            return query.FirstOrDefault();
        }
    }
}
