using Project_Management_System.Views.Developer.Modify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Presenters.Developer
{
    /// <summary>Initializes developer's modify menu views.</summary>
    class DeveloperModifyMenuViewPresenter
    {
        private int userid;
        private IDeveloperModifyMenuView view;

        public DeveloperModifyMenuViewPresenter(IDeveloperModifyMenuView view, int userid)
        {
            this.view = view;
            this.userid = userid;
        }

        /// <summary>
        ///   <para>Initializes modify task view.</para>
        /// </summary>
        public void initModifyTaskView()
        {
            ModifyTaskView modifyMenuView = new ModifyTaskView(userid);
            modifyMenuView.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(modifyMenuView);
            modifyMenuView.Show();
        }
    }
}
