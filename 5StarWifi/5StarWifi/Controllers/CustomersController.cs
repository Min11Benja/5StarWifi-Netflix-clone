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
        //DB Context to acces the Data Base
        private ApplicationDbContext _context;
        //Initialize in the Customers constructor
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        //Since _context is a disposible method we need to dispose it properly with -> 
        //Overide the base method of the base controller class
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ActionResult Index()
        {
            //check if user type is admin or manager if not redirect to login page show does not have permision error
            //return View();
            return Redirect("~/Customers/CustomersTable");
        }
        // GET: Customers/CustomersTable
        public ViewResult CustomersTable() {
            //var customers = GetCustomers();

            //DB set defined in out DB _context wich allows us to get all customers in our DB
            var customers = _context.Customers.ToList();
            //Since this is not emidiately invoked we will use the ToList method to envkke it now and save it as a list

            return View(customers);
        }
        public ActionResult Details(int id) {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else {
                return View(customer);
            }
        }
        private IEnumerable<Customer> GetCustomers() {
            //hard coded list of customers for testing
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John1", Email = "jtren@gmail.com", Password = "qwe123", isSubscribedToCustomer = true, PaymentStatus = "Payed" , MembershipTypeId = 1},
                new Customer { Id = 2, Name = "Pablo2", Email = "ppp@gmail.com", Password = "ppp123", isSubscribedToCustomer = true, PaymentStatus = "Pending" ,MembershipTypeId = 2},
                new Customer { Id = 3, Name = "Teresa3", Email = "tete@gmail.com", Password = "123tete12", isSubscribedToCustomer = false, PaymentStatus = "Canceled" ,MembershipTypeId = 3},
                new Customer { Id = 3, Name = "Benjamin", Email = "redoxz@gmail.com", Password = "1fffade12", isSubscribedToCustomer = false, PaymentStatus = "Debt" ,MembershipTypeId = 3},
            };
            //get customers from the Data Base instead
        }
    }
}