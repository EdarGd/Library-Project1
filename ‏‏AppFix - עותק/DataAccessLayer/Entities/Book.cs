using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public class Book
    {
        [Key]
        [StringLength(13)]
        public string Code { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        [MaxLength(20)]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        [MaxLength(20)]
        public string FirstName_Author { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        [MaxLength(20)]
        public string LastName_Author { get; set; }

        [Required]
        public DateTime PublicationDate { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        [MaxLength(25)]
        public string Category { get; set; }

        [Column(TypeName = "nvarchar(35)")]
        [MaxLength(35)]
        public string SecondaryCategory { get; set; }

        public ICollection<Borrow> borrows { get; set; }

    }
}
