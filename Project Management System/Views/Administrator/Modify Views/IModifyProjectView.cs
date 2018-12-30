using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Administrator.Modify_Views
{
    interface IModifyProjectView
    {
        ListView List { get; }
        string Name { get; set; }
        string Code { get; set; }
        ComboBox User { get; set; }
        void showMessage(string message);
    }
}
