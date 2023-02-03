using AutoMapper;
using Emtec.EmBilling.Forecast.Api.Models.Domain_Library;
using Emtec.EmBilling.Forecast.Manager.Models.Domain_Library;
using Emtec.EmBilling.Forecast.Manager.UsersService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Emtec.EmBilling.Forecast.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;
        private readonly IMapper _mapper;
        public UsersController(IUserService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        //[Route("getAllBooks")]

        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var users= await _service.GetAllUsers();
            //var UsersToManagerModel = _mapper.Map<UserManagerModel>(users);

            List<UserManagerModel> MappedUsers = _mapper.Map<List<User>, List<UserManagerModel>>(users);

            return Ok(MappedUsers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<User?>>> GetSingleUser(int id)
        {
            var user = await _service.GetSingleUser(id);

            //Destination to source 
            var UserDto = _mapper.Map<UserManagerModel>(user);

            if (UserDto == null)
                return NotFound("User Not Found");

            return Ok(UserDto);
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
                return NotFound("User Not Found");
            return Ok(result);
        }


    }
}
