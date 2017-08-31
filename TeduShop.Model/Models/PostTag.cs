using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PostID { get; set; }

        [Key]
        [Column(TypeName = "varchar")]
        public int TagID { get; set; }

        //FK Post
        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }

        //FK Tag
        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}