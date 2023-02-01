using EmBillingWebAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBillingWebAPI.Manager.UserService
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<List<User?>> GetAllUsers()
        {
            var users = await _usersRepository.GetAllUsers();
            return users;
        }
        public async Task<User?> GetSingleUser(int id)
        {
            var user = await _usersRepository.GetSingleUser(id);
            if (user == null)
                return null;
            return user;
        }

        public User AddNewUser(User user)
        {
            _usersRepository.AddNewUser(user);
            return user;
        }

        public async Task<List<User>?> DeleteUser(int id)
        {
            var user = await _usersRepository.DeleteUser(id);
            if (user == null)
                return null;
            return user;

        }

        public async Task<List<User>?> UpdateUser(int id, User request)
        {
            var user = await _usersRepository.UpdateUser(id, request);
            if (user == null)
                return null;

            return user;


        }
    }
}
