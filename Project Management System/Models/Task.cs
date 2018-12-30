using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System.Models
{
    enum Status { New = 1, InProgress = 2, Finished = 3};
    /// <summary>A POCO class that contains Task related fields.</summary>
    class Task
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public string Progress { get; set; }
        public string Deadline { get; set; }
        public string Description { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Project")]
        public int? ProjectId { get; set; }
        public Project Project { get; set; }

        public Task() { }

        public Task(int taskId, string name, Status status, string progress, string deadline, string description)
        {
            this.TaskId = taskId;
            this.Name = name;
            this.Status = status;
            this.Progress = progress;
            this.Deadline = deadline;
            this.Description = description;
        }

    }
}
