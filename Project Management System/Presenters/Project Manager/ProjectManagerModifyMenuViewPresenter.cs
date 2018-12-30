using Project_Management_System.Views.Project_Manager.Modify_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Presenters.Project_Manager
{
    /// <summary>Initializes Project Manager's modify menu views.</summary>
    class ProjectManagerModifyMenuViewPresenter
    {
        private int userid;
        private IProjectManagerModifyMenuView view;

        public ProjectManagerModifyMenuViewPresenter(IProjectManagerModifyMenuView view, int userid)
        {
            this.view = view;
            this.userid = userid;
        }

        /// <summary>
        ///   <para>Initializes modify task view.</para>
        /// </summary>
        public void initModifyTaskView()
        {
            ModifyTaskView modifyTaskView = new ModifyTaskView(userid);
            modifyTaskView.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(modifyTaskView);
            modifyTaskView.Show();
        }
    }
}
