using EmBillingWebAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBillingWebAPI.Manager.RolesService
{
    public class RolesService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RolesService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public async Task<List<Role?>> GetAllRoles()
        {
            var roles = await _roleRepository.GetAllRoles();
            return roles;
        }
        public async Task<Role?> GetSingleRole(int id)
        {
            var role = await _roleRepository.GetSingleRole(id);
            if (role == null)
                return null;
            return role;
        }

        public Role AddNewRole(Role role)
        {
            _roleRepository.AddNewRole(role);
            return role;
        }

        public async Task<List<Role>?> DeleteRole(int id)
        {
            var role = await _roleRepository.DeleteRole(id);
            if (role == null)
                return null;
            return role;

        }

        public async Task<List<Role>?> UpdateRole(int id, Role request)
        {
            var role = await _roleRepository.UpdateRole(id, request);
            if (role == null)
                return null;

            return role;
                

        }
    }
}
