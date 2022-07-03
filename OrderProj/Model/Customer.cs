using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProj.Model
{
    public class Customer
    {
        [Key]
        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string Address { get; set; }
    }
}
