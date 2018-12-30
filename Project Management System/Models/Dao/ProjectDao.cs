using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Models.Dao
{
    /// <summary>An interface that contains various Project related functions for database manipulation.</summary>
    interface ProjectDao
    {
        Boolean exists(string text);
        List<Project> getProjects();
        List<User> getProjectManagers();
        Project getProjectForCode(string text);
        string getProjectNameForId(int? projectid);
        Project getProjectIdForName(string name);
    }
}
