using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Developer
{
    interface IDeveloperView
    {
        Panel panelLeft { get; }
        Panel panelLeftTop { get; }
        Panel panelDivider { get; }
        Panel panelAddMenu { get; }
        Panel panelMain { get; }
    }
}
