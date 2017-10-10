using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Errors")]
    public class Error : Abstract.Auditable
    {
        [Key]
        public int ID { get; set; }

        public string Message { get; set; }
        public string StackTrace { get; set; }
    }
}