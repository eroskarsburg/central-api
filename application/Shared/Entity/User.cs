namespace application.Shared.Entity
{
    public class User
    {
        public short Code { get; set; }
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public string? RG { get; set; }
        public string? Email { get; set; }
        public string? Cellphone { get; set; }
        public DateOnly BirthDate { get; set; }

    }
}
