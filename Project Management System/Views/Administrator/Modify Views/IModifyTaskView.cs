using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Administrator.Modify_Views
{
    interface IModifyTaskView
    {
        string Name { get; set; }
        ComboBox Status { get; set; }
        string Progress { get; set; }
        DateTimePicker Deadline { get; }
        string Description { get; set; }
        ComboBox User { get; set; }
        ListView List { get; }
        ComboBox Project { get; set; }
        void showMessage(string message);
    }
}
