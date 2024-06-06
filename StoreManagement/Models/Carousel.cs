

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Models
{
    public class Carousel :CommonModel

    {
        [Key]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string? folder_name { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string? img_url { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string? carousel_status { get; set; }

    }
}
