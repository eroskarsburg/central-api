using application.Business.Users.GetUser.Models;
using application.Business.Users.GetUser.Repository.Abstractions;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace application.Business.Users.GetUser.Repository
{
    public class GetUserRepository : IGetUserRepository
    {
        public readonly IConfiguration _configuration;
        public readonly SqlConnection _connection;

        public GetUserRepository(IConfiguration configuration, SqlConnection connection)
        {
            _configuration = configuration;
            _connection = new SqlConnection();
        }

        public async Task<UserResponse> GetUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
