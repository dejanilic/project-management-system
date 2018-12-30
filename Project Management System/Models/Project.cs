using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Models
{

    /// <summary>A POCO class that contains Project related fields.</summary>
    class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Task> Task { get; set; }

        public Project() { }

        public Project(string Name, string Code, User User)
        {
            this.Name = Name;
            this.Code = Code;
            this.User = User;
        }

        public Project(int Id, string Name, string Code, User User)
        {
            this.ProjectId = Id;
            this.Name = Name;
            this.Code = Code;
            this.User = User;
        }
    }
}
