using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FinalProject_StephenBrimer.Models
{
    public class Car
    {
        public int Id { get; set; }
        [RegularExpression("\\b(19[3 - 9][0 - 9] | 200[0 - 9] | 201[0 - 2])\\b", ErrorMessage = "Please Enter in a valid year"), Required(ErrorMessage = "Please enter your car manufacture year!")]
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double Mileage{ get; set; }

        public Customer Customer { get; set; }

        public List<Order> Orders { get; set; }




    }
}
