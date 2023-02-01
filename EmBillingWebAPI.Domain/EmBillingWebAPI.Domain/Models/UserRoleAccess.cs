using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBillingWebAPI.Domain.Models
{
    public class UserRoleAccess
    {
        //Id
        public int Id { get; set; }
        //userid from Users table

        public User User { get; set; }
        //RoleId from Roles table
        public Role Role { get; set; }

        //AccessAttribute id from references table
        public Reference AccessAttribute { get; set; }

        public string AccessTypelevel { get; set; }=string.Empty;
    }
}
