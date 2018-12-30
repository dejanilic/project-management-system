using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Administrator.Add_Views
{
    interface IAddNewProjectView
    {
        string Name { get; set; }
        string Code { get; set; }
        ComboBox cBox { get; }
        void showMessage(string message);
    }
}
