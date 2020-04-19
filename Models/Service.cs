using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace FinalProject_StephenBrimer.Models
{
    public class Service
    {
        public int Id { get; set; }

        public string ServiceName { get; set; }

        public double PartPrice { get; set; }

        public double ServicePrice { get; set; }

    }
}
