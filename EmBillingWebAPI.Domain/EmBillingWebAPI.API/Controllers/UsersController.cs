using EmBillingWebAPI.Domain.Models;
using EmBillingWebAPI.Manager.UserService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmBillingWebAPI.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _service;

        public UsersController(IUsersService service)
        {
            _service = service;
        }
        [HttpGet]
        //[Route("getAllBooks")]
        public async Task<ActionResult<List<User?>>> GetAllUsers()
        {

            return await _service.GetAllUsers();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<User?>>> GetSingleUser(int id)
        {
            var user = await _service.GetSingleUser(id);
            if (user == null)
                return NotFound("User Not Found");

            return Ok(user);
        }
        [HttpPost]
        public ActionResult<User> CreateUser(User user)
        {
            var User = _service.AddNewUser(user);

            return Ok(User);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User?>>> DeleteUser(int id)
        {
            var result = await _service.DeleteUser(id);
            if (result == null)
                return NotFound("User Not Found");
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<User>>> UpdateUser(int id, User request)
        {
            var result = await _service.UpdateUser(id, request);
            if (result == null)
                return NotFound("Book Not Found");
            return Ok(result);
        }


    }
}
