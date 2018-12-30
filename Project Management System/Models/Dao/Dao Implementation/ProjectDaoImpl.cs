using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Models.Dao.Dao_Implementation
{
    /// <summary>Implements ProjectDao interface and defines Project related functions for database manipulation.</summary>
    class ProjectDaoImpl : ProjectDao
    {
        private Sql database;

        public ProjectDaoImpl(Sql database)
        {
            this.database = database;
        }

        /// <summary>Checks if a project exists.</summary>
        /// <param name="text">Project code</param>
        public bool exists(string text)
        {
            var projects = from project in database.Projects
                           where project.Code == text
                           select project;
            if (projects.Count() > 0) return true;
            return false;
        }


        /// <summary>Returns a project object for a given project code.</summary>
        /// <param name="text">Project code</param>
        public Project getProjectForCode(string text)
        {
            string[] splitter = text.Split(' ');
            string code = splitter[0];
            var query = from project in database.Projects
                        where project.Code == code
                        select project;
            return query.FirstOrDefault();
        }


        /// <summary>Returns a list of users that have role Project Manager</summary>
        public List<User> getProjectManagers()
        {
            List<User> list = new List<User>();
            list = (from user in database.Users
                    where user.Role.Id == 2
                    select user).ToList();
            return list;
        }

        /// <summary>Returns a project object for a given project name</summary>
        /// <param name="name">Project name</param>
        public Project getProjectIdForName(string name)
        {
            var query = from project in database.Projects
                        where project.Name == name
                        select project;
            return query.FirstOrDefault();
        }

        /// <summary>Returns a list of all projects.</summary>
        public List<Project> getProjects()
        {
            List<Project> projects = new List<Project>();
            projects = (from project in database.Projects
                        select project).ToList();
            return projects;
        }

        /// <summary>Returns a project name for a given project id.</summary>
        /// <param name="projectid">Project id</param>
        public string getProjectNameForId(int? projectid) 
        {
            ProjectDao projectDao = new ProjectDaoImpl(new Sql());
            var query = projectDao.getProjects()
                        .Where(project => project.ProjectId == projectid)
                        .FirstOrDefault()
                        .Name;
            return query.ToString();
        }
    }
}
