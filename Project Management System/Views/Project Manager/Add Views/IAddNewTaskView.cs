using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Project_Manager.Add_Views
{
    interface IAddNewTaskView
    {
        string Name { get; set; }
        ComboBox Status { get; set; }
        string Progress { get; set; }
        DateTimePicker Deadline { get; set; }
        string Description { get; set; }
        ComboBox User { get; set; }
        ComboBox Project { get; set; }
        void showMessage(string message);
    }
}
