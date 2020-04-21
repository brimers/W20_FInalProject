using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_StephenBrimer.Models
{
    public class Customer
    {
        
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter your name!")]
        public string Name { get; set; }

        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email!"), Required(ErrorMessage = "Please enter your email!")]
        public string Email { get; set; }

        [RegularExpression("^[2-9]\\d{2}-\\d{3}-\\d{4}$", ErrorMessage = "Please enter a valid email!"), Required(ErrorMessage = "Please enter your phone number!")]
        public string Phone { get; set; }

        public List<Order> Orders { get; set; }

       

        

    }
}
