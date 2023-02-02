using EmBillingWebAPI.Domain.Models;
using EmBillingWebAPI.Manager.UserService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBillingWebAPI.Infrastructure
{
    public class UsersRepository : IUsersRepository
    {
        //public static List<Users>users= new List<Users>()
        //{
        //    new Users
        //    {
        //        Id= 1,
        //        Name="Abhay",
        //        Email="abhay@gail.com",
        //        IsActive=true,
        //    },
        //    new Users
        //    {
        //        Id= 2,
        //        Name="Vikrant",
        //        Email="vikrant@gail.com",
        //        IsActive=false,
        //    }
        //};
        private readonly DataContext _context;

        public UsersRepository(DataContext context )
        {
            _context = context;
        }

        //public User CreateUser(User user)
        //{
        //    _context.Users.Add(user);
        //    _context.SaveChanges();
        //    return user;
        //}

        //public List<User> GetAllUsers()
        //{
        //    var users=_context.Users.ToList();

        //    return users;
        //}

        public async Task<List<User?>> GetAllUsers()
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

          user.Name= request.Name;
            user.Email= request.Email;
            user.IsActive= request.IsActive;

            await _context.SaveChangesAsync();
            return await _context.Users.ToListAsync();

        }
    }
}
