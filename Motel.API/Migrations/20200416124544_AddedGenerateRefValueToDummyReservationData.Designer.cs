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
    [Migration("20200416124544_AddedGenerateRefValueToDummyReservationData")]
    partial class AddedGenerateRefValueToDummyReservationData
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
                            Ref = new Guid("dbcff082-70d8-4b71-abf9-0ba88f226e59"),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ArrivalDate = new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartureDate = new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfAdults = 1,
                            NumberOfChildren = 3,
                            Ref = new Guid("e91618a6-db23-4719-8df3-e79ad624d9b0"),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            ArrivalDate = new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartureDate = new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfAdults = 1,
                            NumberOfChildren = 2,
                            Ref = new Guid("5b6a50cd-61c4-49db-8dc6-7994c474061d"),
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
                            PasswordHash = new byte[] { 28, 134, 162, 225, 83, 8, 129, 60, 199, 113, 104, 134, 17, 231, 74, 100, 81, 170, 46, 182, 215, 204, 21, 54, 22, 15, 101, 201, 67, 208, 9, 205, 0, 76, 72, 158, 179, 89, 255, 91, 84, 64, 183, 194, 122, 47, 249, 57, 136, 36, 120, 194, 158, 37, 102, 155, 149, 215, 147, 7, 10, 115, 37, 92 },
                            PasswordSalt = new byte[] { 251, 229, 177, 201, 15, 218, 38, 175, 252, 105, 156, 155, 239, 223, 250, 118, 62, 40, 7, 199, 31, 61, 66, 228, 193, 108, 105, 123, 115, 12, 187, 164, 104, 63, 119, 204, 183, 225, 109, 55, 155, 66, 241, 44, 131, 201, 145, 219, 43, 195, 165, 115, 115, 239, 176, 251, 129, 10, 117, 228, 58, 86, 72, 144, 147, 246, 212, 69, 190, 8, 196, 38, 214, 70, 20, 185, 125, 147, 42, 82, 73, 217, 109, 33, 139, 121, 224, 29, 127, 248, 121, 248, 190, 77, 43, 209, 173, 13, 222, 89, 218, 119, 54, 118, 37, 171, 144, 153, 183, 129, 190, 114, 53, 22, 150, 62, 88, 119, 34, 123, 182, 232, 110, 1, 101, 31, 0, 192 },
                            Ref = new Guid("256c438e-4ce8-4a9e-af67-7582c3c4bd2f")
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
