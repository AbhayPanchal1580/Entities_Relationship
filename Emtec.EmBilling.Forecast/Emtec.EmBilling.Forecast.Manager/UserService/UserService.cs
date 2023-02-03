
using Emtec.EmBilling.Forecast.Api.Models.Domain_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emtec.EmBilling.Forecast.Manager.UsersService
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _usersRepository;

        public UserService(IUserRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<List<User>> GetAllUsers()
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
