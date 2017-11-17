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
    }
}
