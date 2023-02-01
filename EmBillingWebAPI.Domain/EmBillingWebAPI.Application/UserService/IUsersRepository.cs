using EmBillingWebAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBillingWebAPI.Manager.UserService
{
    public interface IUsersRepository
    {
        Task<List<User?>> GetAllUsers();
        Task<User?> GetSingleUser(int id);

        User AddNewUser(User user);

        Task<List<User>?> UpdateUser(int id, User request);

        Task<List<User>?> DeleteUser(int id);

    }
}
