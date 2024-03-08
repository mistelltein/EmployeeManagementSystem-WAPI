using System.ComponentModel.DataAnnotations;

namespace ANC_WAPI_EmployeeApi.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string? Name { get; set; }

        [Required, MaxLength(50)]
        public string? Surname { get; set; }

        [Required, MaxLength(100)]
        public string? Position { get; set; }

        [Required, MaxLength(100)]
        public string? Department { get; set; }
    }
}
