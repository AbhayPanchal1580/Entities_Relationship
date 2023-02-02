using EmBillingWebAPI.Domain.Models;
using EmBillingWebAPI.Manager.RolesService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmBillingWebAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _service;

        public RoleController(IRoleService service)
        {
            _service = service;
        }

        [HttpGet]
        //[Route("getAllBooks")]
        public async Task<ActionResult<List<Role?>>> GetAllRoles()
        {

            return await _service.GetAllRoles();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Role?>>> GetSingleRole(int id)
        {
            var role = await _service.GetSingleRole(id);
            if (role == null)
                return NotFound("Role Not Exist");

            return Ok(role);
        }
        [HttpPost]
        public ActionResult<Role> CreateRole(Role role)
        {
            var Role = _service.AddNewRole(role);

            return Ok(Role);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Role?>>> DeleteRole(int id)
        {
            var result = await _service.DeleteRole(id);
            if (result == null)
                return NotFound("Role Not exists");
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Role>>> UpdateRole(int id, Role request)
        {
            var result = await _service.UpdateRole(id, request);
            if (result == null)
                return NotFound("Role Not exists");
            return Ok(result);
        }
    }
}
