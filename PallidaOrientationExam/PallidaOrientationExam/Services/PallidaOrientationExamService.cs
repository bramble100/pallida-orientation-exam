using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PallidaOrientationExam.Repositories;

namespace PallidaOrientationExam.Services
{
    public class PallidaOrientationExamService
    {
        private PallidaOrientationExamRepository pallidaOrientationExamRepository;

        public PallidaOrientationExamService(PallidaOrientationExamRepository pallidaOrientationExamRepository) 
            => this.pallidaOrientationExamRepository = pallidaOrientationExamRepository;
    }
}
