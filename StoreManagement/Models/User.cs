using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Models
{
    public class User : CommonModel
    {
        [Key]
        public int id {  get; set; }
        [Column(TypeName ="nvarchar(250)")]
        public string? name { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string? username { get; set; }
        [Column(TypeName ="nvarchar(500)")]
        [Required]
        public string? email { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string? password { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string? phone_number { get; set; }= string.Empty;
        public bool is_active { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string? token { get; set; } 
        [Column(TypeName = "nvarchar(250)")]
        public string? activation_code { get; set; }
        [Required]
        public int role_id { get; set; }
        
        // Navigation property
        public Role role { get; set; }
        public ICollection<Order> order { get; set; }

      public ICollection<Product> product { get; set; }
      public ICollection<Cart> cart { get; set; }
      public ICollection<Wishlist> wishlist { get; set; }
       

    }
}
