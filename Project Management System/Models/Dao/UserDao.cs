using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Models.Dao
{
    /// <summary>An interface that contains various User related functions for database manipulation.</summary>
    interface UserDao
    {
        Boolean exists(string username);
        Boolean isValid(string username, string password);
        Boolean checkDevelopersTasks(string user, string splitted);
        List<User> getUsers();
        List<User> getUsersWithoutAdmin();
        User getUserForUsername(string username);
        User getUserForId(int id);
        string formatFullName(int? userid);
        int getUserIdForFullName(string name, string surname);
    }
}
