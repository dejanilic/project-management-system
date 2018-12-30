using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Views
{
    interface ILoginView
    {
        string Username { get; }
        string Password { get; }
        void showMessage(string message);
    }
}
