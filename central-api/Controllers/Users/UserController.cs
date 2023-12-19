using Microsoft.AspNetCore.Mvc;

namespace central_api.Controllers.Users
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet(Name = "user/select")]
        public async Task<IActionResult> SelectAllUsers()
        {
            return ;
        }
    }
}
