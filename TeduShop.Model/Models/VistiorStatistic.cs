using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("VistiorStatistics")]
    public class VistiorStatistic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [Required]
        public DateTime VisitedDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string IPAddress { get; set; }
    }
}