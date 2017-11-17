using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PallidaOrientationExam.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PallidaOrientationExam.Controllers
{
    [Route("api")]
    public class APIController : Controller
    {
        private PallidaOrientationExamService pallidaOrientationExamService;

        public APIController(PallidaOrientationExamService pallidaOrientationExamService)
            => this.pallidaOrientationExamService = pallidaOrientationExamService;

        [HttpGet]
        [Route("search/{brand}")]
        public IActionResult SearchBrand(string brand) 
            => Json(pallidaOrientationExamService.SearchResultsBrand(brand));

        [HttpGet]
        [Route("search")]
        public IActionResult Search()
        {
            // HMZ-140 or any part of the license plate (like MZ-1)
            if (Request.Query.Count == 0)
            {
                return BadRequest("No search criteria specified.");
            }
            else if (Request.Query.ContainsKey("police"))
            {
                return Json(pallidaOrientationExamService.SearchResultsPolice());
            }
            else if (Request.Query.ContainsKey("diplomat"))
            {
                return Json(pallidaOrientationExamService.SearchResultsDiplomat());
            }
            else if (Request.Query.ContainsKey("q"))
            {
                try
                {
                    return Json(pallidaOrientationExamService.SearchNormalCarsByPlate(Request.Query["q"]));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }                
            }

            return NotFound();
        }

    }
}
