using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Models
{
    /// <summary>A POCO class that contains User related fields.</summary>
    class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public User() { }

        public User(int Id, string Username, string Password, string Name, string Surname, string Email, Role Role)
        {
            this.UserId = Id;
            this.Username = Username;
            this.Password = Password;
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Role = Role;
        }
    }  
}
