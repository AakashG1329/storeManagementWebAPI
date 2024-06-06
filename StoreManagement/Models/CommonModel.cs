using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Models
{
    public class CommonModel
    {
        public DateTime created_date {  get; set; }
        public DateTime? updated_date {  get; set; }
        public int? updated_by {  get; set; }
        public int created_by {  get; set; }
        public bool status {  get; set; }

    }
}
