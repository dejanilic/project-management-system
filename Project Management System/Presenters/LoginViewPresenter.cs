using Project_Management_System.Models;
using Project_Management_System.Models.Dao;
using Project_Management_System.Models.Dao.Dao_Implementation;
using Project_Management_System.Views;
using Project_Management_System.Views.Developer;
using Project_Management_System.Views.Project_Manager;
using System.Linq;
using System.Threading;
using System;
using System.Windows.Forms;

namespace Project_Management_System.Presenters
{
    class LoginViewPresenter
    {
        private int userid;
        private Thread thread;
        private Login loginView;
        private ILoginView view;
        private UserDao userDao = new UserDaoImpl(new Sql());

        public LoginViewPresenter(ILoginView view, Login loginView)
        {
            this.view = view;
            this.loginView = loginView;
        }

        public void login()
        {
            if (userDao.isValid(view.Username, view.Password))
            {
                User user = userDao.getUsers()
                    .Where(u => u.Username == view.Username && u.Password == view.Password)
                    .FirstOrDefault();
                this.userid = user.UserId;
                if (user.RoleId == 1)
                {
                    loginView.Close();
                    thread = new Thread(openAdministratorView);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }

                else if (user.RoleId == 2)
                {
                    loginView.Close();
                    thread = new Thread(openProjectManagerView);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                    
                else
                {
                    loginView.Close();
                    thread = new Thread(openDeveloperView);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                    
            } else
            {
                view.showMessage("User do not exist!");
            }
        }

        private void openAdministratorView()
        {
            Application.Run(new AdministratorView());
        }

        private void openProjectManagerView()
        {
            Application.Run(new ProjectManagerView(this.userid));
        }

        private void openDeveloperView()
        {
            Application.Run(new DeveloperView(this.userid));
        }
    }
}
