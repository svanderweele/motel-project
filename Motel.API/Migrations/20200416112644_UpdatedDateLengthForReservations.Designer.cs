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
    [Migration("20200416112644_UpdatedDateLengthForReservations")]
    partial class UpdatedDateLengthForReservations
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
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ArrivalDate = new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartureDate = new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfAdults = 1,
                            NumberOfChildren = 3,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            ArrivalDate = new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartureDate = new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfAdults = 1,
                            NumberOfChildren = 2,
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
                            PasswordHash = new byte[] { 69, 151, 33, 156, 7, 86, 53, 174, 60, 15, 248, 73, 234, 239, 143, 47, 81, 137, 184, 244, 173, 132, 225, 209, 224, 74, 217, 154, 3, 111, 91, 125, 23, 33, 207, 180, 60, 51, 37, 35, 198, 20, 175, 223, 114, 209, 126, 70, 54, 109, 70, 132, 111, 14, 123, 30, 172, 167, 123, 230, 183, 120, 159, 69 },
                            PasswordSalt = new byte[] { 177, 98, 220, 125, 139, 59, 181, 250, 190, 138, 245, 83, 92, 204, 133, 140, 206, 61, 88, 29, 228, 170, 191, 210, 198, 142, 61, 255, 220, 213, 182, 239, 128, 234, 96, 89, 238, 37, 220, 126, 68, 239, 203, 255, 249, 50, 246, 213, 49, 243, 108, 115, 133, 36, 84, 98, 8, 208, 62, 173, 122, 6, 174, 80, 255, 83, 237, 92, 59, 96, 57, 165, 26, 58, 182, 170, 206, 91, 90, 91, 246, 112, 96, 249, 242, 17, 178, 13, 4, 143, 143, 141, 87, 137, 41, 51, 17, 255, 236, 244, 199, 46, 247, 249, 207, 6, 38, 95, 135, 159, 112, 64, 177, 210, 1, 168, 58, 158, 129, 228, 14, 124, 174, 209, 142, 72, 16, 187 },
                            Ref = new Guid("c34fc911-0425-4cff-87c6-d92949d9986b")
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
