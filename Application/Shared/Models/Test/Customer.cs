using System.ComponentModel.DataAnnotations;

namespace application.Shared.Models.Test
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Adress { get; set; }
        public string? Phone { get; set; }
        public ICollection<OrderDetail> Orders { get; set; } = null!;
    }
}
