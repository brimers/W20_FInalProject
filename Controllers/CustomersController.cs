using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_StephenBrimer.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_StephenBrimer.Controllers
{
    public class CustomersController : Controller
    {
        private Database _dbContext;

        public CustomersController()
        {
            _dbContext = new Database();
        }

        public IActionResult Index()
        { 
            return View("Login");
        }

        
        [HttpPost]
        public IActionResult SaveCust(Customer customer)
        {

            if (customer.Id == null)
            {
                _dbContext.Customers.Add(customer);
            }
            else
            {  
                var customerInDb = _dbContext.Customers.Find(customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Email = customer.Email;
            }

            _dbContext.SaveChanges();

            return View("BookCar");
        }

        public IActionResult SaveCar(Car car
        )
            {
            return View();
        }

        public IActionResult BookService()
        {
            return View();
        }


    }
}