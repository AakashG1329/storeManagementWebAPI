

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Models
{
    public class Order :CommonModel
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string? address { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string? order_status { get; set; }
        [Required]
        public int user_id { get; set; }
        [Required]
        public int product_id { get; set; }
        public Product orderProduct { get; set; }
        public User orderUser { get; set; }
    }
}
