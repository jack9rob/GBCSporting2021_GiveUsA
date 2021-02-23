﻿// <auto-generated />
using System;
using GBCSporting2021_GiveUsA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GBCSporting2021_GiveUsA.Migrations
{
    [DbContext(typeof(TechnicalSupportContext))]
    partial class TechnicalSupportContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("GBCSporting2021_GiveUsA.Models.Country", b =>
                {
                    b.Property<string>("CountryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = "CAD",
                            Name = "Canada"
                        },
                        new
                        {
                            CountryId = "USA",
                            Name = "United States of America"
                        },
                        new
                        {
                            CountryId = "AUS",
                            Name = "Australia"
                        },
                        new
                        {
                            CountryId = "MEX",
                            Name = "MEX"
                        },
                        new
                        {
                            CountryId = "UK",
                            Name = "United Kingdom"
                        });
                });

            modelBuilder.Entity("GBCSporting2021_GiveUsA.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postalcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("CountryId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "123 Home Drive",
                            City = "Toronto",
                            CountryId = "CAD",
                            Email = "jack.robinson@gmail.com",
                            Firstname = "Jack",
                            Lastname = "Robinson",
                            Phone = "123-456-7899",
                            Postalcode = "M4B 1G5",
                            Province = "Ontario"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "123 Home Drive",
                            City = "Toronto",
                            CountryId = "MEX",
                            Email = "fatih@gmail.com",
                            Firstname = "Fatih",
                            Lastname = "Com",
                            Phone = "123-456-7899",
                            Postalcode = "M4B 1G5",
                            Province = "Ontario"
                        },
                        new
                        {
                            CustomerId = 3,
                            Address = "123 Home Drive",
                            City = "Toronto",
                            CountryId = "AUS",
                            Email = "jack.robinson@gmail.com",
                            Firstname = "Young-il",
                            Lastname = "Kim",
                            Phone = "123-456-7899",
                            Postalcode = "M4B 1G5",
                            Province = "Ontario"
                        });
                });

            modelBuilder.Entity("GBCSporting2021_GiveUsA.Models.Incident", b =>
                {
                    b.Property<int>("IncidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateClosed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOpened")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("TechnicianId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IncidentId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("TechnicianId");

                    b.ToTable("Incidents");

                    b.HasData(
                        new
                        {
                            IncidentId = 1,
                            CustomerId = 1,
                            DateOpened = new DateTime(2021, 2, 23, 12, 18, 8, 85, DateTimeKind.Local).AddTicks(8936),
                            Description = "Alex smashed by macbook because he was too jealous",
                            ProductId = 1,
                            TechnicianId = 1,
                            Title = "Macbook broke"
                        },
                        new
                        {
                            IncidentId = 2,
                            CustomerId = 2,
                            DateOpened = new DateTime(2021, 2, 23, 12, 18, 8, 86, DateTimeKind.Local).AddTicks(75),
                            Description = "Coffee spilled all over me",
                            ProductId = 2,
                            TechnicianId = 3,
                            Title = "Coffe spill"
                        },
                        new
                        {
                            IncidentId = 3,
                            CustomerId = 3,
                            DateOpened = new DateTime(2021, 2, 23, 12, 18, 8, 86, DateTimeKind.Local).AddTicks(106),
                            Description = "Wrong yoga mat was delivered to me",
                            ProductId = 3,
                            TechnicianId = 3,
                            Title = "Yoga mat is wrong colour"
                        });
                });

            modelBuilder.Entity("GBCSporting2021_GiveUsA.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Code = "MAC-AIR-M1",
                            Name = "Macbook Air M1",
                            Price = 1200.0,
                            ReleaseDate = new DateTime(2021, 2, 23, 12, 18, 8, 83, DateTimeKind.Local).AddTicks(8108)
                        },
                        new
                        {
                            ProductId = 2,
                            Code = "BLK-COF",
                            Name = "Black Coffee",
                            Price = 2.5,
                            ReleaseDate = new DateTime(2021, 2, 23, 12, 18, 8, 85, DateTimeKind.Local).AddTicks(5723)
                        },
                        new
                        {
                            ProductId = 3,
                            Code = "yoga-mat",
                            Name = "Yoga Mat",
                            Price = 10.0,
                            ReleaseDate = new DateTime(2021, 2, 23, 12, 18, 8, 85, DateTimeKind.Local).AddTicks(5753)
                        });
                });

            modelBuilder.Entity("GBCSporting2021_GiveUsA.Models.Technician", b =>
                {
                    b.Property<int>("TechnicianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TechnicianId");

                    b.ToTable("Technicians");

                    b.HasData(
                        new
                        {
                            TechnicianId = 1,
                            Email = "Yoon@email.com",
                            Name = "Alex Yoon",
                            Phone = "647-347-3345"
                        },
                        new
                        {
                            TechnicianId = 2,
                            Email = "doe@hotmail.com",
                            Name = "John Doe",
                            Phone = "416-774-5412"
                        },
                        new
                        {
                            TechnicianId = 3,
                            Email = "janster@gmail.com",
                            Name = "Jane Doe",
                            Phone = "122-458-4775"
                        });
                });

            modelBuilder.Entity("GBCSporting2021_GiveUsA.Models.Customer", b =>
                {
                    b.HasOne("GBCSporting2021_GiveUsA.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("GBCSporting2021_GiveUsA.Models.Incident", b =>
                {
                    b.HasOne("GBCSporting2021_GiveUsA.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GBCSporting2021_GiveUsA.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GBCSporting2021_GiveUsA.Models.Technician", "Technician")
                        .WithMany()
                        .HasForeignKey("TechnicianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Technician");
                });
#pragma warning restore 612, 618
        }
    }
}
