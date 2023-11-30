using System.ComponentModel.DataAnnotations;

namespace Tribeca.WebAPI.Entities
{
    public class Client
    {
        public object Offices;

        [Key] //Client will have primary key
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int OfficeID { get; set; }
        public string Address { get; set; }
        public bool IsHeadOffice { get; set; }
        public int? EmployeeID { get; set; }
        public string EmployeeName { get; set; }
    }

}


