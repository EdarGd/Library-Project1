using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public class ExistingCategory
    {
        [Index("CI_Category", IsClustered = true)]
        [Key]
        [Column(Order = 1, TypeName = "nvarchar(25)")]
        [MaxLength(25)]
        public string Category { get; set; }

        [Key]
        [Column(Order = 1 ,TypeName = "nvarchar(35)")]
        [MaxLength(35)]
        public string SecondaryCategory { get; set; }
    }
}
