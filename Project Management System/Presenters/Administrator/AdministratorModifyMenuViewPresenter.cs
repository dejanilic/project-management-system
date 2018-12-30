using Project_Management_System.Views.Administrator.Modify_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Presenters
{
    /// <summary>Initializes administrator's modify menu views.</summary>
    class AdministratorModifyMenuViewPresenter
    {
        private IAdministratorModifyMenuView view;

        public AdministratorModifyMenuViewPresenter(IAdministratorModifyMenuView view)
        {
            this.view = view;
        }

        /// <summary>
        ///   <para>Initializes modify project view.</para>
        /// </summary>
        public void initModifyProjectView()
        {
            ModifyProjectView modifyProjectView = new ModifyProjectView();
            modifyProjectView.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(modifyProjectView);
            modifyProjectView.Show();
        }

        /// <summary>
        ///   <para>Initializes modify task view.</para>
        /// </summary>
        public void initModifyTaskView()
        {
            ModifyTaskView modifyTaskView = new ModifyTaskView();
            modifyTaskView.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(modifyTaskView);
            modifyTaskView.Show();
        }

        /// <summary>
        ///   <para>Initializes modify user view.</para>
        /// </summary>
        public void initModifyUserView()
        {
            ModifyUserView modifyUserView = new ModifyUserView();
            modifyUserView.TopLevel = false;
            view.Panel.Controls.Clear();
            view.Panel.Controls.Add(modifyUserView);
            modifyUserView.Show();
        }
    }
}
