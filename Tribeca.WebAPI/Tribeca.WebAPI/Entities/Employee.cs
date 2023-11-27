using System.ComponentModel.DataAnnotations;

namespace Tribeca.WebAPI.Entities
{
    public class Employee
    {
        
        [Key] //EmployeeId will have primary key
        public int EmployeeID { get; set; } 
        public int ClientID { get; set; }
        public int OfficeID { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public DateOnly DateOfBirth { get; set; }
    }
}
