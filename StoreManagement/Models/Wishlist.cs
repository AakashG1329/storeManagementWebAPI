

using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Models
{
    public class Wishlist :CommonModel
    {
        [Key]
        public int id { get; set; }
        public bool notification { get; set; }
        public bool is_add_to_wishlist { get; set; }
        [Required]
        public int user_id { get; set; }
        [Required]
        public int product_id { get; set; }

   
        public User wishlistUser { get; set; }
        public Product wishlistProduct { get; set; }
    }
}
