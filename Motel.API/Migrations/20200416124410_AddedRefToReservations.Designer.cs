﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Motel.API.Models;

namespace Motel.API.Migrations
{
    [DbContext(typeof(MotelContext))]
    [Migration("20200416124410_AddedRefToReservations")]
    partial class AddedRefToReservations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Motel.API.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime");

                    b.Property<int>("NumberOfAdults")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfChildren")
                        .HasColumnType("int");

                    b.Property<Guid>("Ref")
                        .HasColumnType("char(36)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArrivalDate = new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartureDate = new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfAdults = 2,
                            NumberOfChildren = 1,
                            Ref = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ArrivalDate = new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartureDate = new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfAdults = 1,
                            NumberOfChildren = 3,
                            Ref = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            ArrivalDate = new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartureDate = new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfAdults = 1,
                            NumberOfChildren = 2,
                            Ref = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Motel.API.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RoomLayoutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomLayoutId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoomLayoutId = 1
                        },
                        new
                        {
                            Id = 2,
                            RoomLayoutId = 2
                        });
                });

            modelBuilder.Entity("Motel.API.Models.RoomLayout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("RoomLayouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Single"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Double"
                        });
                });

            modelBuilder.Entity("Motel.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("longblob");

                    b.Property<Guid>("Ref")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "simon@example.com",
                            Name = "Simon van der Weele",
                            PasswordHash = new byte[] { 102, 139, 229, 44, 118, 86, 172, 230, 254, 106, 232, 97, 219, 76, 93, 43, 239, 41, 212, 120, 188, 213, 195, 83, 250, 237, 142, 51, 1, 162, 162, 230, 42, 223, 141, 97, 124, 177, 53, 111, 27, 138, 209, 34, 214, 224, 153, 9, 47, 110, 84, 108, 66, 6, 91, 174, 237, 152, 81, 237, 187, 55, 61, 199 },
                            PasswordSalt = new byte[] { 179, 121, 193, 212, 64, 99, 0, 49, 69, 175, 23, 216, 164, 75, 155, 75, 96, 179, 104, 232, 91, 40, 213, 43, 92, 218, 50, 153, 40, 109, 223, 153, 102, 138, 210, 194, 184, 22, 147, 192, 34, 252, 56, 201, 236, 16, 146, 27, 57, 117, 233, 90, 19, 229, 27, 180, 102, 18, 91, 42, 239, 238, 156, 107, 153, 46, 23, 104, 252, 236, 24, 212, 83, 108, 205, 182, 94, 129, 34, 155, 56, 148, 222, 210, 139, 190, 216, 52, 192, 167, 38, 191, 95, 102, 176, 115, 99, 85, 221, 108, 174, 76, 202, 71, 170, 217, 94, 36, 168, 89, 248, 39, 172, 104, 137, 220, 183, 40, 75, 89, 36, 40, 162, 141, 219, 108, 204, 48 },
                            Ref = new Guid("e6e44ff9-19aa-47be-9e4f-271e174b62e3")
                        });
                });

            modelBuilder.Entity("Motel.API.Models.Reservation", b =>
                {
                    b.HasOne("Motel.API.Models.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Motel.API.Models.Room", b =>
                {
                    b.HasOne("Motel.API.Models.RoomLayout", "RoomLayout")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomLayoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
