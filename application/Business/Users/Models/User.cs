namespace application.Business.Users.Models
{
    public class UserRequest
    {
        public string? Name { get; set; }
        public string? CPF { get; set; }
    }

    public class UserResponse
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
    }
}
