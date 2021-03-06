﻿using PallidaOrientationExam.Models;
using System.Collections.Generic;

namespace PallidaOrientationExam.ViewModels
{
    public class SearchResult
    {
        public List<LicensePlate> LicensePlates { get; set; }
        public string ErrorMessage { get; set; }

        public SearchResult()
        {
            LicensePlates = new List<LicensePlate>();
            ErrorMessage = string.Empty;
        }
    }
}
