using Microsoft.Build.Framework;

namespace CrudApplication.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Salary { get; set; }
    }
}
