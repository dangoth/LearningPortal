﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortalPerfomanceEmployees.Data;

#nullable disable

namespace PortalPerfomanceEmployees.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20220817102847_Seeding")]
    partial class Seeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PortalPerfomanceEmployees.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 25,
                            Created = new DateTime(2022, 8, 17, 12, 28, 47, 670, DateTimeKind.Local).AddTicks(8957),
                            Level = 0,
                            Name = "Emp1"
                        },
                        new
                        {
                            Id = 2,
                            Age = 30,
                            Created = new DateTime(2022, 8, 17, 12, 28, 47, 670, DateTimeKind.Local).AddTicks(8997),
                            Level = 1,
                            Name = "Emp2"
                        },
                        new
                        {
                            Id = 3,
                            Age = 35,
                            Created = new DateTime(2022, 8, 17, 12, 28, 47, 670, DateTimeKind.Local).AddTicks(9000),
                            Level = 2,
                            Name = "Emp3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
