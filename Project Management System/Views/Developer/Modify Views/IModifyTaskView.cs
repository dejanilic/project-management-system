using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Developer.Modify
{
    interface IModifyTaskView
    {
        ComboBox Status { get; set; }
        string Progress { get; set; }
        string Description { get; set; }
        ListView List { get; }
        void showMessage(string message);
    }
}
