using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HMAT.Models;


namespace HMAT.Controllers
{ 
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            //get Movies/Random
            var movie = new Movie() { Name = "SRK !!" };

            var customers = new List<Customer>
            {
               new Customer {Name="CUSTOMER 1"},
               new Customer {Name="Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                //Movie = movie,
               // Customers = customers;
            };
            return View(viewModel);
        }
        public ActionResult Edit(int id)
        {

            return Content("id="+id);
        }
        public ActionResult cindex(int? page_index,string sortby)
        {
            return Content(string.Format("pageindex := {0} sort by := {1}", page_index, sortby));
        }

        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year+"/"+month);
        }
        
        
    }
}