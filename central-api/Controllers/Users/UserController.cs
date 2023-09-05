using Microsoft.AspNetCore.Mvc;

namespace central_api.Controllers.Users
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet(Name = "user/select")]
        public IActionResult SelectUsers()
        {
            return;
        }
    }
}
