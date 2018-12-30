using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Project_Manager.Modify_Views
{
    interface IModifyTaskView
    {
        ComboBox Status { get; }
        string Progress { get; set; }
        DateTimePicker Deadline { get; }
        string Description { get; set; }
        ComboBox User { get; }
        ListView List { get; }
        void showMessage(string message);
    }
}
