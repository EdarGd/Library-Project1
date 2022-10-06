using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public class User
    {

        [Key]
        [Column(TypeName = "nchar(9)")]
        [StringLength(9)]
        public string Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        // SQL Server (Type) -> data type = bit  
        public bool Type { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        public string Password { get; set; }

        public ICollection<Borrow> borrows { get; set; }
    }
}
