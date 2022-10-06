using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public class Borrow
    {
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Book")]
        [StringLength(13)]
        public string Code { get; set; }
        public Book Book { get; set; }


        [Required]
        [Column(Order = 2)]
        [ForeignKey("User")]
        [StringLength(9)]
        public string Id { get; set; }
        public User User { get; set; }


    }
}
