﻿// <auto-generated />
using System;
using Airport.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Airport.Domain.Migrations
{
    [DbContext(typeof(AirportContext))]
    [Migration("20210201172130_AddFlightsToAirplane")]
    partial class AddFlightsToAirplane
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Airport.Domain.Airplane", b =>
                {
                    b.Property<int>("AirplaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Company")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AirplaneId");

                    b.ToTable("Airplanes");

                    b.HasData(
                        new
                        {
                            AirplaneId = 1,
                            Company = 0,
                            Model = "Model1",
                            Name = "Airplane1"
                        },
                        new
                        {
                            AirplaneId = 2,
                            Company = 5,
                            Model = "Model2",
                            Name = "Airplane2"
                        },
                        new
                        {
                            AirplaneId = 3,
                            Company = 1,
                            Model = "Model1",
                            Name = "Airplane3"
                        },
                        new
                        {
                            AirplaneId = 4,
                            Company = 2,
                            Model = "Model3",
                            Name = "Airplane4"
                        },
                        new
                        {
                            AirplaneId = 5,
                            Company = 1,
                            Model = "Model2",
                            Name = "Airplane5"
                        },
                        new
                        {
                            AirplaneId = 6,
                            Company = 3,
                            Model = "Model6",
                            Name = "Airplane6"
                        });
                });

            modelBuilder.Entity("Airport.Domain.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AirplaneId")
                        .HasColumnType("int");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FlightDuration")
                        .HasColumnType("float");

                    b.HasKey("FlightId");

                    b.HasIndex("AirplaneId");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            FlightId = 1,
                            AirplaneId = 1,
                            Destination = "Mexico City",
                            FlightDuration = 17.0
                        },
                        new
                        {
                            FlightId = 2,
                            AirplaneId = 1,
                            Destination = "New York",
                            FlightDuration = 21.0
                        },
                        new
                        {
                            FlightId = 3,
                            AirplaneId = 2,
                            Destination = "Mexico City",
                            FlightDuration = 14.0
                        },
                        new
                        {
                            FlightId = 4,
                            AirplaneId = 3,
                            Destination = "Madrid",
                            FlightDuration = 5.0
                        },
                        new
                        {
                            FlightId = 5,
                            AirplaneId = 4,
                            Destination = "Moscow",
                            FlightDuration = 6.0
                        },
                        new
                        {
                            FlightId = 6,
                            AirplaneId = 5,
                            Destination = "London",
                            FlightDuration = 8.0
                        },
                        new
                        {
                            FlightId = 7,
                            AirplaneId = 5,
                            Destination = "Melbourne",
                            FlightDuration = 25.0
                        });
                });

            modelBuilder.Entity("Airport.Domain.Passanger", b =>
                {
                    b.Property<int>("PassangerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PassangerId");

                    b.ToTable("Passangers");

                    b.HasData(
                        new
                        {
                            PassangerId = 1,
                            Age = 21,
                            FirstName = "Jovan",
                            LastName = "Saponjic"
                        },
                        new
                        {
                            PassangerId = 2,
                            Age = 30,
                            FirstName = "Pera",
                            LastName = "Peric"
                        },
                        new
                        {
                            PassangerId = 3,
                            Age = 45,
                            FirstName = "Zika",
                            LastName = "Zikic"
                        },
                        new
                        {
                            PassangerId = 4,
                            Age = 17,
                            FirstName = "Milan",
                            LastName = "Jovanovic"
                        });
                });

            modelBuilder.Entity("Airport.Domain.Reservation", b =>
                {
                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.Property<int>("PassangerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfReservation")
                        .HasColumnType("datetime2");

                    b.HasKey("SeatId", "PassangerId", "DateOfReservation");

                    b.HasIndex("PassangerId");

                    b.HasIndex("SeatId")
                        .IsUnique();

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            SeatId = 2,
                            PassangerId = 1,
                            DateOfReservation = new DateTime(2021, 2, 1, 18, 21, 29, 9, DateTimeKind.Local).AddTicks(2187)
                        },
                        new
                        {
                            SeatId = 14,
                            PassangerId = 1,
                            DateOfReservation = new DateTime(2021, 2, 1, 18, 21, 29, 15, DateTimeKind.Local).AddTicks(6173)
                        },
                        new
                        {
                            SeatId = 4,
                            PassangerId = 2,
                            DateOfReservation = new DateTime(2021, 2, 1, 18, 21, 29, 15, DateTimeKind.Local).AddTicks(6257)
                        },
                        new
                        {
                            SeatId = 11,
                            PassangerId = 3,
                            DateOfReservation = new DateTime(2021, 2, 1, 18, 21, 29, 15, DateTimeKind.Local).AddTicks(6267)
                        },
                        new
                        {
                            SeatId = 6,
                            PassangerId = 4,
                            DateOfReservation = new DateTime(2021, 2, 1, 18, 21, 29, 15, DateTimeKind.Local).AddTicks(6272)
                        });
                });

            modelBuilder.Entity("Airport.Domain.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AirplaneId")
                        .HasColumnType("int");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("SeatId");

                    b.HasIndex("AirplaneId");

                    b.ToTable("Seats");

                    b.HasData(
                        new
                        {
                            SeatId = 1,
                            AirplaneId = 1,
                            Class = "Business",
                            Price = 150.0
                        },
                        new
                        {
                            SeatId = 2,
                            AirplaneId = 1,
                            Class = "Business",
                            Price = 180.0
                        },
                        new
                        {
                            SeatId = 3,
                            AirplaneId = 1,
                            Class = "Economy",
                            Price = 100.0
                        },
                        new
                        {
                            SeatId = 4,
                            AirplaneId = 1,
                            Class = "FirstClass",
                            Price = 220.0
                        },
                        new
                        {
                            SeatId = 5,
                            AirplaneId = 2,
                            Class = "Business",
                            Price = 160.0
                        },
                        new
                        {
                            SeatId = 6,
                            AirplaneId = 2,
                            Class = "Economy",
                            Price = 90.0
                        },
                        new
                        {
                            SeatId = 7,
                            AirplaneId = 2,
                            Class = "Economy",
                            Price = 100.0
                        },
                        new
                        {
                            SeatId = 8,
                            AirplaneId = 3,
                            Class = "FirstClass",
                            Price = 250.0
                        },
                        new
                        {
                            SeatId = 9,
                            AirplaneId = 3,
                            Class = "Business",
                            Price = 190.0
                        },
                        new
                        {
                            SeatId = 10,
                            AirplaneId = 4,
                            Class = "Economy",
                            Price = 80.0
                        },
                        new
                        {
                            SeatId = 11,
                            AirplaneId = 4,
                            Class = "Economy",
                            Price = 110.0
                        },
                        new
                        {
                            SeatId = 12,
                            AirplaneId = 5,
                            Class = "Business",
                            Price = 175.0
                        },
                        new
                        {
                            SeatId = 13,
                            AirplaneId = 5,
                            Class = "Economy",
                            Price = 120.0
                        },
                        new
                        {
                            SeatId = 14,
                            AirplaneId = 6,
                            Class = "FirstClass",
                            Price = 225.0
                        },
                        new
                        {
                            SeatId = 15,
                            AirplaneId = 6,
                            Class = "FirstClass",
                            Price = 240.0
                        });
                });

            modelBuilder.Entity("Airport.Domain.Flight", b =>
                {
                    b.HasOne("Airport.Domain.Airplane", "Airplane")
                        .WithMany("Flights")
                        .HasForeignKey("AirplaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airplane");
                });

            modelBuilder.Entity("Airport.Domain.Reservation", b =>
                {
                    b.HasOne("Airport.Domain.Passanger", "Passanger")
                        .WithMany("Seats")
                        .HasForeignKey("PassangerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Airport.Domain.Seat", "Seat")
                        .WithMany("Passangers")
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Passanger");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("Airport.Domain.Seat", b =>
                {
                    b.HasOne("Airport.Domain.Airplane", null)
                        .WithMany("Seats")
                        .HasForeignKey("AirplaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airport.Domain.Airplane", b =>
                {
                    b.Navigation("Flights");

                    b.Navigation("Seats");
                });

            modelBuilder.Entity("Airport.Domain.Passanger", b =>
                {
                    b.Navigation("Seats");
                });

            modelBuilder.Entity("Airport.Domain.Seat", b =>
                {
                    b.Navigation("Passangers");
                });
#pragma warning restore 612, 618
        }
    }
}
