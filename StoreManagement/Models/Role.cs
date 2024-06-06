using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Models
{
    public class Role : CommonModel
    {
        [Key]
        public int id {  get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string? role_name { get; set; }
        public bool role_status    { get; set; }
        public ICollection<User> user { get; set; }

    }
}
