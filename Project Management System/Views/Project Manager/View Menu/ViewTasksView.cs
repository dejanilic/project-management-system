using Project_Management_System.Presenters.Project_Manager;
using Project_Management_System.Views.Administrator.View_Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Project_Manager.View_Menu
{
    public partial class ViewTasksView : Form, IViewTasksView
    {
        ViewTasksViewPresenter presenter;

        public ViewTasksView(int userid)
        {
            InitializeComponent();
            presenter = new ViewTasksViewPresenter(this, userid);
            presenter.initList();
            Util.expandListViewHeader(List);
        }

        public ListView List
        {
            get
            {
                return listViewTasks;
            }
        }
    }
}
