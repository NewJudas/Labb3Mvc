using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CarModel.Models;

namespace CarModel.Migrations
{
    [DbContext(typeof(CarContext))]
    partial class CarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarModel.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CarBrand");

                    b.Property<string>("CarModel");

                    b.Property<int>("CarTypeId");

                    b.Property<string>("RegNr");

                    b.HasKey("Id");

                    b.HasIndex("CarTypeId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarModel.Models.CarType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Enginge");

                    b.HasKey("Id");

                    b.ToTable("CarType");
                });

            modelBuilder.Entity("CarModel.Models.Car", b =>
                {
                    b.HasOne("CarModel.Models.CarType", "CarType")
                        .WithMany()
                        .HasForeignKey("CarTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
