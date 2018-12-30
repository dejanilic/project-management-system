using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Administrator.Add_Views
{
    interface IAddNewTaskView
    {
        string Name { get; set; }
        ComboBox Status { get; }
        string Progress { get; set; }
        DateTimePicker Deadline { get; }
        string Description { get; set; }
        ComboBox User { get; }
        ComboBox Project { get; }
        void showMessage(string message);
    }
}
