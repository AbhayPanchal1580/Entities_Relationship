
using Emtec.EmBilling.Forecast.Manager.UsersService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emtec.EmBilling.Forecast.Api.Models.Domain_Library;
using Emtec.EmBilling.Forecast.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Emtec.EmBilling.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;

        }

        public async Task<User?> GetSingleUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
                return null;
            return user;
        }

        public User AddNewUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public async Task<List<User>?> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return await _context.Users.ToListAsync();

        }

        public async Task<List<User>?> UpdateUser(int id, User request)
        {


            var user = await _context.Users.FindAsync(id);

            if (user == null)
                return null;

            user.Name = request.Name;
            user.Email = request.Email;
            user.IsActive = request.IsActive;

            object value = await _context.SaveChangesAsync();
            return await _context.Users.ToListAsync();

        }
    }
}
