using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Models
{
    enum Position { Administrator = 1, ProjectManager = 2, Developer = 3};
    /// <summary>A POCO class that contains Role related fields.</summary>
    class Role
    {
        public int Id { get; set; }
        public Position Position { get; set; }

        public ICollection<User> User { get; set; }

        public Role() { }

        public Role (Position position)
        {
            this.Position = Position;
        }
    }
}
