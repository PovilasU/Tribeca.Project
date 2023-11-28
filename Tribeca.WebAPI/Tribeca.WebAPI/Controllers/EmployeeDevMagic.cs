
namespace Tribeca.WebAPI.Controllers
{
    internal class EmployeeDevMagic
    {
        public int EmployeeId { get; set; }
        public int ClientID { get; set; }
        public int OfficeID { get; set; }
        public string EmployeeName { get; set; }
        public string Bio { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string StarSign { get; set; }
        public string BioAsDevMagic { get; set; }
    }

    internal class EmployeeStarSign
    {
     
        public string EmployeeName { get; set; }
        public string StarSign { get; set; }
       
    }
}