﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Administrator.View_Views
{
    interface IViewProjectsView
    {
        ListView List { get; }
        ComboBox User { get; }
    }
}
