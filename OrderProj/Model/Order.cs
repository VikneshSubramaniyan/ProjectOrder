using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProj.Model
{
    
        public class Order
        {
        [Key]
        public int OrderId { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string OrderItem { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string OrderInfo { get; set; }

        }
    
}
