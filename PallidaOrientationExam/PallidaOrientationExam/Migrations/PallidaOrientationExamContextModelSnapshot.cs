using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PallidaOrientationExam.Entities;

namespace PallidaOrientationExam.Migrations
{
    [DbContext(typeof(PallidaOrientationExamContext))]
    partial class PallidaOrientationExamContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PallidaOrientationExam.Models.LicensePlate", b =>
                {
                    b.Property<string>("Plate")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("Brand")
                        .HasMaxLength(50);

                    b.Property<string>("Color")
                        .HasMaxLength(50);

                    b.Property<string>("Model")
                        .HasMaxLength(50);

                    b.Property<int>("Year");

                    b.HasKey("Plate");

                    b.ToTable("LicensePlates");
                });
        }
    }
}
