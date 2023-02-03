
using Emtec.EmBilling.Forecast.Api.Models.Domain_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emtec.EmBilling.Forecast.Manager.UsersService
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();
        Task<User?> GetSingleUser(int id);

        User AddNewUser(User user);

        Task<List<User>?> UpdateUser(int id, User request);

        Task<List<User>?> DeleteUser(int id);
    }
}
