using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Administrator.View_Views
{
    interface IViewUsersView
    {
        ListView List { get; }
        ComboBox Role { get; }
    }
}
