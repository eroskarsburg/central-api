namespace application.Business.Users.GetUser.Models
{
    public class GetUserRequest
    {
        public string? Name { get; set; }
        public string? CPF { get; set; }
    }

    public class PostUserRequest
    {

    }

    public class PutUserRequest
    {

    }

    public class UserResponse
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
    }
}
