using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PallidaOrientationExam.Entities;

namespace PallidaOrientationExam.Repositories
{
    public class PallidaOrientationExamRepository
    {
        private PallidaOrientationExamContext pallidaOrientationExamContext;

        public PallidaOrientationExamRepository(PallidaOrientationExamContext pallidaOrientationExamContext) 
            => this.pallidaOrientationExamContext = pallidaOrientationExamContext;
    }
}
