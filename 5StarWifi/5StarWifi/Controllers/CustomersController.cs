using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _5StarWifi.Models;

namespace _5StarWifi.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            //check if user type is admin or manager if not redirect to login page show does not have permision error
            //return View();
            return Redirect("~/Customers/CustomersTable");
        }
        // GET: Customers/CustomersTable
        public ViewResult CustomersTable() {
            return View();
        }
       
        private IEnumerable<Customer> GetCustomers() {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John1"},
                new Customer { Id = 2, Name = "Pablo2"},
                new Customer { Id = 3, Name = "Teresa3"}
            };
        }
    }
}