

using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Models
{
    public class Cart :CommonModel
    {
        [Key]
        public int id { get; set; }
        public bool notification { get; set; }
        public bool is_add_to_cart { get; set; }
        public int quantity { get; set; }
        public int totall_price { get; set; }
        [Required]
        public int user_id { get; set; }
        [Required]
        public int product_id { get; set; }
        public User cartUser { get; set; }
        public Product cartProduct { get; set; }
    }
}
