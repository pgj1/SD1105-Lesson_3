using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sakila.Models
{
    public partial class NewCustomer
    {
       [Key]
        public int new_cust_id { get; set; }
        public string name { get; set; }
        public int codenum { get; set; }
        public DateTime last_updated { get; set; }

    }
}
