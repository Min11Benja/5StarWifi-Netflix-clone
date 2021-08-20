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
            var customers = GetCustomers();
            return View(customers);
        }       
        private IEnumerable<Customer> GetCustomers() {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John1", Email = "jtren@gmail.com", Password = "qwe123", isSubscribedToCustomer = true, PaymentStatus = "Payed" , MembershipTypeId = 1},
                new Customer { Id = 2, Name = "Pablo2", Email = "ppp@gmail.com", Password = "ppp123", isSubscribedToCustomer = true, PaymentStatus = "Pending" ,MembershipTypeId = 2},
                new Customer { Id = 3, Name = "Teresa3", Email = "tete@gmail.com", Password = "123tete12", isSubscribedToCustomer = false, PaymentStatus = "Canceled" ,MembershipTypeId = 3},
                new Customer { Id = 3, Name = "Benjamin", Email = "redoxz@gmail.com", Password = "1fffade12", isSubscribedToCustomer = false, PaymentStatus = "Debt" ,MembershipTypeId = 3},
            };
        }
    }
}