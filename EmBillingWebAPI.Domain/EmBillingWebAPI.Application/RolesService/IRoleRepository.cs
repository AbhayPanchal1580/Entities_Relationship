using EmBillingWebAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBillingWebAPI.Manager.RolesService
{
    public interface IRoleRepository
    {
        Task<List<Role?>> GetAllRoles();
        Task<Role?> GetSingleRole(int id);

        Role AddNewRole(Role role);

        Task<List<Role>?> UpdateRole(int id, Role request);

        Task<List<Role>?> DeleteRole(int id);
    }
}
