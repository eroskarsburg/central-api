using application.Business.Users.GetUser.Models;

namespace application.Business.Users.GetUser.Service.Abstractions
{
    public interface IGetUserService
    {
        public Task<UserResponse> GetUser(int id);
    }
}
