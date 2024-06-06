using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Models
{
    public class BlackListedToken
    {
        public int id { get; set; }
        public string token { get; set; }
        public DateTime logoutDate { get; set; }

    }
}
