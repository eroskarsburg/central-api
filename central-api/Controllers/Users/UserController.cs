using application.Business.Users.GetUser.Models;
using application.Business.Users.GetUser.Service.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.Marshalling;

namespace central_api.Controllers.Users
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IGetUserService _service;

        public UserController(IGetUserService service) => _service = service;

        [HttpGet(Name = "user/get")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                UserResponse response = await _service.GetUser(id);
                return Ok(response);
            }
            catch (Exception) { throw; }
        }

        [HttpPost(Name = "user/post")]
        public async Task<IActionResult> Post(GetUserRequest request)
        {
            try
            {
                UserResponse response = await _service.GetUser(request);
                return Ok(response);
            }
            catch (Exception) { throw; }
        }

        [HttpPut(Name = "user/put")]
        public async Task<IActionResult> Put(int id)
        {
            try
            {
                UserResponse response = await _service.GetUser(id);
                return Ok(response);
            }
            catch (Exception) { throw; }
        }

        [HttpPut(Name = "user/put")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                UserResponse response = await _service.GetUser(id);
                return Ok(response);
            }
            catch (Exception) { throw; }
        }
    }
}
