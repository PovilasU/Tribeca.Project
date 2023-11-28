using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tribeca.WebAPI.Entities
{
    public class Office
    {
        [Key]
        public int OfficeID { get; set; } // Primary Key
        public int ClientID { get; set; }
        public string Address { get; set; }
        public bool IsHeadOffice { get; set; }
        [NotMapped]
        public object Employees { get; set; }
    }

}
