

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Models
{
    public class Category:CommonModel
    {
        [Key]
        public int id{ get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string? cat_name { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string? cat_code { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string? product_type { get; set; }
        public ICollection<Product> product { get; set; }
    }
}
