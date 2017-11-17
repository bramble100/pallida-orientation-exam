using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaOrientationExam.Models
{
    public class LicensePlates
    {
        [Key]
        [MaxLength(50)]
        public string Plate { get; set; }
        [MaxLength(50)]
        public string Brand { get; set; }
        [MaxLength(50)]
        public string Model { get; set; }
        [MaxLength(50)]
        public string Color { get; set; }
        public int Year { get; set; }
    }
}
