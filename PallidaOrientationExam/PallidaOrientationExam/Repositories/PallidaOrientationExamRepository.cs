using System;
using System.Collections.Generic;
using System.Linq;
using PallidaOrientationExam.Entities;
using PallidaOrientationExam.Models;

namespace PallidaOrientationExam.Repositories
{
    public class PallidaOrientationExamRepository
    {
        private PallidaOrientationExamContext pallidaOrientationExamContext;

        public PallidaOrientationExamRepository(PallidaOrientationExamContext pallidaOrientationExamContext)
            => this.pallidaOrientationExamContext = pallidaOrientationExamContext;

        public List<LicensePlate> SearchNormalCarsByPlate(string searchString)
            => (from plate in pallidaOrientationExamContext.LicensePlates
                where plate.Plate.Contains(searchString)
                select plate).ToList();

        public List<LicensePlate> SearchResultsPolice()
            => (from plate in pallidaOrientationExamContext.LicensePlates
                where plate.Plate.StartsWith("RB")
                select plate).ToList();

        public List<LicensePlate> SearchResultsDiplomat()
            => (from plate in pallidaOrientationExamContext.LicensePlates
                where plate.Plate.StartsWith("DT")
                select plate).ToList();

        public List<LicensePlate> SearchResultsBrand(string brand)
            => (from plate in pallidaOrientationExamContext.LicensePlates
                where plate.Brand.Equals(brand)
                select plate).ToList();

    }
}
