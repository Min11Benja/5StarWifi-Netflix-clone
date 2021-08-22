using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _5StarWifi.Models;
using _5StarWifi.ViewModels;

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
        // Customers/Details/2
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
        // Customers/Add/
        public ActionResult Add()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new AddCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View(viewModel);            
        }
        //Make sure this can only be called through an Http Post and not an Http Get
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            //MVC framework binds this viewModel to the submited data

            //To add the parameters into our Customers DB table we need to add it to our _context 
            _context.Customers.Add(customer);
            //this wont add it to the DB just yet it just gets stored in memory to persist the changes we need to call this other method
            _context.SaveChanges();
            return Redirect("~/Customers/CustomersTable");
        }
        // Customers/Edit/2
        public ActionResult Edit(int id) {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }            
        }
       
    }
}