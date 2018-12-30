using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Models.Dao
{
    /// <summary>An interface that contains various Task related functions for database manipulation.</summary>
    interface TaskDao
    {
        List<Task> getTasks();
        List<Task> getTasksForProjectId(int id);
    }
}
