using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    [Table("orders")]
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }

        public int CustomerId { get; set; }
        public Customers Customer { get; set; }
        public int EmployeeId { get; set; }
        public Employee employee { get; set; }

        List<Payment> payments { get; set; }
        List<Products> products { get; set; }


    }
}