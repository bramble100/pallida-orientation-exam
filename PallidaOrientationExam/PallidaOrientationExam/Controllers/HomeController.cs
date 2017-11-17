using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PallidaOrientationExam.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult SearchForm(string searchString)
        {
            // HMZ-140 or any part of the license plate (like MZ-1)
            return View(searchString);
        }

        [HttpGet]
        [Route("search/{searchString}")]
        public IActionResult SearchResultsNormal(string searchString)
        {
            return View();
        }

        [HttpGet]
        [Route("search/police/{searchString}")]
        public IActionResult SearchResultsPolice(string searchString)
        {
            return View();
        }

        [HttpGet]
        [Route("search/diplomat/{searchString}")]
        public IActionResult SearchResultsDiplomat(string searchString)
        {
            return View();
        }
    }
}
