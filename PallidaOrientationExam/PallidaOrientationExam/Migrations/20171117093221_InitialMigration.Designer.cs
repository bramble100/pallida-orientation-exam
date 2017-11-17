using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PallidaOrientationExam.Entities;

namespace PallidaOrientationExam.Migrations
{
    [DbContext(typeof(PallidaOrientationExamContext))]
    [Migration("20171117093221_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
