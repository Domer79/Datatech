using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Web.Models
{
    [Table("AddressBook")]
    public class AddressBook
    {
        [Key]
        public int Id { get; set; }

        public string Fio { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Unit { get; set; }

        public string Post { get; set; }
    }
}