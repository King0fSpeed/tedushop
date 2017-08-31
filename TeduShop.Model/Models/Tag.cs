using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [Required]
        [MaxLength(50)]
        public string ID { get; set; }

        [MaxLength(50)]
        public string Type { get; set; }
    }
}