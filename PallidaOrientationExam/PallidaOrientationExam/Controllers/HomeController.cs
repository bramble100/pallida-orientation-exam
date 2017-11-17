using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PallidaOrientationExam.Services;
using PallidaOrientationExam.Models;
using PallidaOrientationExam.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PallidaOrientationExam.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private PallidaOrientationExamService pallidaOrientationExamService;

        public HomeController(PallidaOrientationExamService pallidaOrientationExamService)
            => this.pallidaOrientationExamService = pallidaOrientationExamService;

        [HttpGet]
        public IActionResult Index(SearchResult searchResult)
        {
            // HMZ-140 or any part of the license plate (like MZ-1)
            return View(searchResult ?? new SearchResult());
        }

        [HttpGet]
        [Route("search")]
        public IActionResult SearchResults()
        {
            if (Request.Query.Count == 0)
            {
                return BadRequest("Nothing is searched for.");
            }
            else if (Request.Query.ContainsKey("police"))
            {
                return RedirectToAction("Index", pallidaOrientationExamService.SearchResultsPolice());
            }
            else if (Request.Query.ContainsKey("diplomat"))
            {
                return RedirectToAction("Index", pallidaOrientationExamService.SearchResultsDiplomat());
            }

            try
            {
                return View(pallidaOrientationExamService.SearchNormalCarsByPlate("2"));
            }
            catch (Exception ex)
            {
                return View(new List<LicensePlate>());
            }
        }

        [HttpGet]
        [Route("/police")]
        public IActionResult SearchResultsPolice()
            => View(pallidaOrientationExamService.SearchResultsPolice());

        [HttpGet]
        [Route("/diplomat")]
        public IActionResult SearchResultsDiplomat()
            => View(pallidaOrientationExamService.SearchResultsDiplomat());

        [HttpGet]
        [Route("search/{brand}")]
        public IActionResult SearchBrand(string brand)
            => View(pallidaOrientationExamService.SearchResultsBrand(brand));

    }
}
