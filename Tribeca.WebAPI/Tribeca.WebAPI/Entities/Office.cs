using System.ComponentModel.DataAnnotations;

namespace Tribeca.WebAPI.Entities
{
    public class Office
    {
        [Key]
        public int OfficeID { get; set; } // Primary Key
        public int ClientID { get; set; }
        public string Address { get; set; }
        public bool IsHeadOffice { get; set; }
    }

}
