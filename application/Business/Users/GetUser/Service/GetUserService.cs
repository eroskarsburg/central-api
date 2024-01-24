using application.Business.Users.GetUser.Models;
using application.Business.Users.GetUser.Repository.Abstractions;
using application.Business.Users.GetUser.Service.Abstractions;

namespace application.Business.Users.GetUser.Service
{
    public class GetUserService : IGetUserService
    {
        private readonly IGetUserRepository _repository;

        public GetUserService(IGetUserRepository userRepository)
        {
            _repository = userRepository;
        }

        public async Task<UserResponse> GetUser(int id)
        {
            return await _repository.GetUser(id);
        }
    }
}
