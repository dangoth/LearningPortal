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
    [DbContext(typeof(AppDbContext))]
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
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

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

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Created = new DateTime(2022, 8, 23, 14, 11, 43, 878, DateTimeKind.Local).AddTicks(9076),
                            DateOfBirth = new DateTime(2000, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Emp1",
                            LastName = "Test1",
                            Role = 0,
                            Seniority = 0
                        },
                        new
                        {
                            EmployeeId = 2,
                            Created = new DateTime(2022, 8, 23, 14, 11, 43, 878, DateTimeKind.Local).AddTicks(9107),
                            DateOfBirth = new DateTime(1980, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Emp2",
                            LastName = "Test2",
                            Role = 1,
                            Seniority = 1
                        },
                        new
                        {
                            EmployeeId = 3,
                            Created = new DateTime(2022, 8, 23, 14, 11, 43, 878, DateTimeKind.Local).AddTicks(9109),
                            DateOfBirth = new DateTime(2005, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Emp3",
                            LastName = "Test3",
                            Role = 2,
                            Seniority = 2
                        });
                });

            modelBuilder.Entity("PortalPerfomanceEmployees.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GivenName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Created = new DateTime(2022, 8, 23, 14, 11, 43, 878, DateTimeKind.Local).AddTicks(9177),
                            EmailAddress = "admin@email.com",
                            GivenName = "adm",
                            Password = "1234",
                            Role = 2,
                            Username = "admin"
                        },
                        new
                        {
                            UserId = 2,
                            Created = new DateTime(2022, 8, 23, 14, 11, 43, 878, DateTimeKind.Local).AddTicks(9181),
                            EmailAddress = "emp@email.com",
                            GivenName = "emp",
                            Password = "1234",
                            Role = 0,
                            Username = "emp"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
