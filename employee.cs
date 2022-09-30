using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    [Table("employee")]
    public class Employee
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string leve { get; set; }

        public List<Orders> orders { get; set; }
    }
}