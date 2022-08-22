﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortalPerfomanceEmployees.Data;

#nullable disable

namespace PortalPerfomanceEmployees.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Seniority")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 8, 22, 22, 21, 49, 875, DateTimeKind.Local).AddTicks(5518),
                            DateOfBirth = new DateTime(2000, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Emp1",
                            LastName = "Test1",
                            Role = 0,
                            Seniority = 0,
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2022, 8, 22, 22, 21, 49, 875, DateTimeKind.Local).AddTicks(5557),
                            DateOfBirth = new DateTime(1980, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Emp2",
                            LastName = "Test2",
                            Role = 1,
                            Seniority = 1,
                            TeamId = 1
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2022, 8, 22, 22, 21, 49, 875, DateTimeKind.Local).AddTicks(5560),
                            DateOfBirth = new DateTime(2005, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Emp3",
                            LastName = "Test3",
                            Role = 2,
                            Seniority = 2,
                            TeamId = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
