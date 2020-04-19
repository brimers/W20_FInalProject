using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_StephenBrimer.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public Customer Customer { get; set; }

        public List<Service> Services { get; set; }

        public int OrderNumber { get; set; }

        public string AddNote { get; set; }
    }
}
