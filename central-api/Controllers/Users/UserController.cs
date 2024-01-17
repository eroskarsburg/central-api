using application.Business.Users.Models;
using application.Business.Users.Service;
using Microsoft.AspNetCore.Mvc;

namespace central_api.Controllers.Users
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service) => _service = service;

        [HttpGet(Name = "user/select")]
        public async Task<IActionResult> SelectUser(UserRequest request)
        {
            try
            {

            }
            catch (Exception) { throw; }
        }
    }
}
