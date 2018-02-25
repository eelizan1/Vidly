using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models; 

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            // create instance of movie model
            // import Vidly.Models to use 
            Movie movie = new Movie() { Name = "Shrek!" }; // the Name property is spelled as the model's property, Name
            // render view with the model, movie
            // return View(movie);
            return Content("Hello, World");
        }
    }
}