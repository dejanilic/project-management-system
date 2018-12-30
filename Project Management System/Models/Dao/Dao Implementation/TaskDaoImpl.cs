using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Models.Dao.Dao_Implementation
{
    /// <summary>Implements TaskDao interface and defines Task related functions for database manipulation.</summary>
    class TaskDaoImpl : TaskDao
    {
        Sql database = new Sql();


        /// <summary>Returns a list of all tasks.</summary>
        public List<Task> getTasks()
        {
            List<Task> list = new List<Task>();
            list = (from task in database.Tasks
                    select task).ToList();
            return list;
        }


        /// <summary>Returns a list of tasks for a given project id</summary>
        /// <param name="id">Project id</param>
        public List<Task> getTasksForProjectId(int id)
        {
            List<Task> list = new List<Task>();
            list = (from task in database.Tasks
                    where task.ProjectId == id
                    select task).ToList();
            return list;
        }
    }
}
