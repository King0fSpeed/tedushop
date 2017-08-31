using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        public string Content { get; set; }

        [MaxLength(250)]
        public string MetaDescription { get; set; }

        [MaxLength(250)]
        public string MetaKeyword { get; set; }

        public bool Status { get; set; }
    }
}