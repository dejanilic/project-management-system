using Project_Management_System.Models;
using Project_Management_System.Views.Developer.View_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Management_System.Presenters.Developer
{
    /// <summary>Initializes developer's view menu views.</summary>
    class DeveloperViewMenuViewPresenter
    {
        private int userid;
        private IDeveloperViewMenuView view;

        public DeveloperViewMenuViewPresenter(IDeveloperViewMenuView view, int userid)
        {
            this.view = view;
            this.userid = userid;
        }

        /// <summary>
        ///   <para>Initializes view task view.</para>
        /// </summary>
        public void viewTasks()
        {
            ViewTasksView viewTasks = new ViewTasksView(userid);
            viewTasks.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(viewTasks);
            viewTasks.Show();
        }
    }
}
