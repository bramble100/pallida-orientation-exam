using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PallidaOrientationExam.Services;
using PallidaOrientationExam.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PallidaOrientationExam.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        private PallidaOrientationExamService pallidaOrientationExamService;

        public HomeController(PallidaOrientationExamService pallidaOrientationExamService) 
            => this.pallidaOrientationExamService = pallidaOrientationExamService;

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
            try
            {
                return View(pallidaOrientationExamService.SearchNormalCarsByPlate(searchString));
            }
            catch (Exception)
            {
                return View(new List<LicensePlate>());
            }
        }

        [HttpGet]
        [Route("/search/police")]
        public IActionResult SearchResultsPolice()
        {
            return View();
        }

        [HttpGet]
        [Route("/search/diplomat")]
        public IActionResult SearchResultsDiplomat()
        {
            return View();
        }
    }
}
