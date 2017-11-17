using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PallidaOrientationExam.Models;

namespace PallidaOrientationExam.Entities
{
    public class PallidaOrientationExamContext :DbContext
    {
        public DbSet<LicensePlate> LicensePlates { get; private set; }

        public PallidaOrientationExamContext(DbContextOptions<PallidaOrientationExamContext> dbContextOptions) : base(dbContextOptions)
        {
        }
    }
}
