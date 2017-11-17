using System;
using PallidaOrientationExam.Repositories;
using System.Collections.Generic;
using PallidaOrientationExam.Models;

namespace PallidaOrientationExam.Services
{
    public class PallidaOrientationExamService
    {
        private PallidaOrientationExamRepository pallidaOrientationExamRepository;

        public PallidaOrientationExamService(PallidaOrientationExamRepository pallidaOrientationExamRepository)
            => this.pallidaOrientationExamRepository = pallidaOrientationExamRepository;

        public List<LicensePlate> SearchNormalCarsByPlate(string searchString)
        {
            if (searchString.Length > 7)
            {
                throw new ArgumentOutOfRangeException("Sorry, the submitted licence plate is too long.");
            }

            foreach (char character in searchString)
            {
                if (!IsValidLIcensePlateCharacter(character))
                {
                    throw new ArgumentOutOfRangeException("Sorry, the submitted licence plate is not valid.");
                }
            }

            return pallidaOrientationExamRepository.SearchNormalCarsByPlate(searchString);
        }

        public static bool IsValidLIcensePlateCharacter(char character) 
            => (Char.IsLetterOrDigit(character) || character.Equals('-'));

        public List<LicensePlate> SearchResultsPolice()
            => pallidaOrientationExamRepository.SearchResultsPolice();

        public List<LicensePlate> SearchResultsDiplomat()
            => pallidaOrientationExamRepository.SearchResultsDiplomat();

        public List<LicensePlate> SearchResultsBrand(string brand)
            => pallidaOrientationExamRepository.SearchResultsBrand(brand);
    }
}
