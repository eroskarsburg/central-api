using application.Business.Users.GetUser.Models;

namespace application.Business.Users.GetUser.Repository.Abstractions
{
    public interface IGetUserRepository
    {
        public Task<UserResponse> GetUser(int id);
    }
}
