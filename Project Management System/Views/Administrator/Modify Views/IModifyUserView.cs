using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Administrator.Modify_Views
{
    interface IModifyUserView
    {
        string Username { get; set; }
        string Password { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Email { get; set; }
        ComboBox Role { get; set; }
        ListView List { get; }
        void showMessage(string message);
    }
}
