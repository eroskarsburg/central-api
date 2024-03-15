using application.Business.Users.Models;

namespace application.Business.Users.Service
{
    public interface IUserService
    {
        public Task<UserResponse> SelectUser(UserRequest request);
    }
}
