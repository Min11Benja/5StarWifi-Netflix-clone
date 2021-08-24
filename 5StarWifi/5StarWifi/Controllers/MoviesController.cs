using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _5StarWifi.Models;
using _5StarWifi.ViewModels;

namespace _5StarWifi.Controllers
{
    public class MoviesController : Controller
    {
        //DB Context to acces the Data Base
        private ApplicationDbContext _context;
        //Initialize in the Movies constructor
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        //Since _context is a disposible method we need to dispose it properly with -> 
        //Overide the base method of the base controller class
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movie
        public ActionResult Index()
        {
            //return View();
            return Redirect("~/Movies/MovieTable");
        }
        // GET: Movie/MovieTable
        public ViewResult MovieTable()
        {            
            //DB set defined in out DB _context wich allows us to get all customers in our DB
            var movies = _context.Movies.ToList();
            //Since this is not emidiately invoked we will use the ToList method to envkke it now and save it as a list
            return View(movies);            
        }
    }
}