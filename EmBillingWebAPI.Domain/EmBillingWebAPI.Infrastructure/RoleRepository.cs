using EmBillingWebAPI.Domain.Models;
using EmBillingWebAPI.Manager.RolesService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBillingWebAPI.Infrastructure
{
    public class RoleRepository:IRoleRepository
    {
        
            private readonly DataContext _context;

            public RoleRepository(DataContext context)
            {
            _context = context;
            }

            public async Task<List<Role?>> GetAllRoles()
            {
                var roles = await _context.Roles.ToListAsync();
                return roles;

            }

            public async Task<Role?> GetSingleRole(int id)
            {
                var role = await _context.Roles.FindAsync(id);
                if (role == null)
                    return null;
                return role;
            }

            public Role AddNewRole(Role role)
            {
                _context.Roles.Add(role);
                _context.SaveChanges();
                return role;
            }

            public async Task<List<Role>?> DeleteRole(int id)
            {
                var role = await _context.Roles.FindAsync(id);
                if (role == null)
                    return null;

                _context.Roles.Remove(role);
                await _context.SaveChangesAsync();
                return await _context.Roles.ToListAsync();

            }

            public async Task<List<Role>?> UpdateRole(int id, Role request)
            {


                var role = await _context.Roles.FindAsync(id);

                if (role == null)
                    return null;

                role.Name = request.Name;
            role.StartDate = request.StartDate;
            role.EndDate = request.EndDate;
            
                await _context.SaveChangesAsync();
                return await _context.Roles.ToListAsync();

            }
        }
    }

