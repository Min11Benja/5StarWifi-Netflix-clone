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
            var membershipType = _context.MembershipTypes.SingleOrDefault(m => m.Id == customer.MembershipTypeId);
            
            var viewModel = new DetailsCustomerViewModel
            {
                Customer = customer,
                MembershipType = membershipType
            };
            
            if (customer == null)
            {
                return HttpNotFound();
            }
            else {
                return View(viewModel);
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
        // Customers/Edit/2
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            var membershipType = _context.MembershipTypes.SingleOrDefault(m => m.Id == customer.MembershipTypeId);
            var membershipTypesList = _context.MembershipTypes.ToList();

            var viewModel = new UpdateCustomerViewModel
            {
                Customer = customer,
                MembershipType = membershipType,
                MembershipTypesList = membershipTypesList
            };
            //if the customers id exist we return the view else show error message            
            if (customer == null)
            {
                //standard 404 error
                return HttpNotFound();
            }
            else
            {
                return View(viewModel);
            }
        }
        //Make sure this can only be called through an Http Post and not an Http Get
        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            //MVC framework binds this viewModel to the submited data
            if (customer.Id == 0)
            {
                //its a new customer lets add it
                //To add the parameters into our Customers DB table we need to add it to our _context 
                _context.Customers.Add(customer);                
            }
            else {
                //its an existing customer we need to update the info
                //for this we need to get it from the Database first
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                //update its property based on the forms values
                customerInDb.Name = customer.Name;
                customerInDb.Email = customer.Email;
                customerInDb.Password = customer.Password;
                customerInDb.Adress = customer.Adress;
                customerInDb.Phone = customer.Phone;
                customerInDb.isSubscribedToCustomer = customer.isSubscribedToCustomer;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;                
                customerInDb.StartDate = customer.StartDate;
                customerInDb.EndDate = customer.EndDate;
                //Mapper.Map(customer, customerInDb); - Needs a Data Transfer Object - to limit properties that can be updated else its not secure to use this                
            }            
            //this wont add/update info to the DB just yet it just gets stored in memory to persist the changes we need to call this other method
            _context.SaveChanges();            
            
            return Redirect("~/Customers/CustomersTable");
        }
        // Customers/Delete/2
        public ActionResult Delete(int id)
        {
            var customerToDelete = _context.Customers.SingleOrDefault(c => c.Id == id);

            //if the customers id exist we delete it and return the view else show error message            
            if (customerToDelete == null)
            {
                //standard 404 error
                return HttpNotFound();
            }
            else
            {
                //Delete the object with the specified key               
                _context.Customers.Remove(customerToDelete);
                //this wont add/update info to the DB just yet it just gets stored in memory to persist the changes we need to call this other method
                _context.SaveChanges();
                return Redirect("~/Customers/CustomersTable");
            }
        }
    }
}