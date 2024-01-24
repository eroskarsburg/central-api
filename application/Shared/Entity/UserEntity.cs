using application.Business.Users.GetUser.Models;

namespace application.Shared.Entity
{
    public class UserEntity
    {
        public UserEntity(GetUserRequest user)
        {
            Name = user.Name;
            CPF = user.CPF;
        }

        public short Code { get; set; }
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public string? RG { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
