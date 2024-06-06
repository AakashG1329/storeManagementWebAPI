

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Models
{
    public class Product :CommonModel
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string item_number { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string product_name { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string description { get; set; }
        public int price { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string img_url { get; set; }
        [Required]
        public int category_id { get; set; }
        [Required]
        public int seller_id { get; set; }
        public Category category { get; set; }
       public User seller { get; set; }
      public ICollection<Order> order { get; set; }
        //public ICollection<Wishlist> wishlist { get; set; }
       public ICollection<Cart> cart { get; set; }
        public ICollection<Wishlist> wishlist { get; set; }
    }
}

