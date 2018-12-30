using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Models.Dao.Dao_Implementation
{
    /// <summary>Implements RoleDao interface and defines Role related functions for database manipulation.</summary>
    class RoleDaoImpl : RoleDao
    {
        Sql database = new Sql();

        /// <summary>Returns a role object for a given role name.</summary>
        /// <param name="text">Role name</param>
        public Role getRole(string text)
        {
            Position position;
            Enum.TryParse(text, out position);
            var query = from role in database.Roles
                        where role.Id == (int)position
                        select role;
            return query.FirstOrDefault();
        }
    }
}
