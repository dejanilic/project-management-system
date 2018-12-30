using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Project_Manager.Add_Views
{
    interface IAddNewProjectView
    {
        string Name { get; set; }
        string Code { get; set; }
        ComboBox Users { get; set; }
        void showMessage(string message);
    }
}
