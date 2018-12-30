using Project_Management_System.Presenters.Developer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Views.Developer.View_Views
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
