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
    [Migration("20200416165739_AddedSoftDeletesToReservations")]
    partial class AddedSoftDeletesToReservations
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

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime");

                    b.Property<int>("NumberOfAdults")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfChildren")
                        .HasColumnType("int");

                    b.Property<Guid>("Ref")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

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
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartureDate = new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfAdults = 2,
                            NumberOfChildren = 1,
                            Ref = new Guid("0d1a70be-6876-4f51-81e6-821d22eae51b"),
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ArrivalDate = new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartureDate = new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfAdults = 1,
                            NumberOfChildren = 3,
                            Ref = new Guid("318311d2-0c95-41a7-974f-a96a5d693b96"),
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            ArrivalDate = new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartureDate = new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfAdults = 1,
                            NumberOfChildren = 2,
                            Ref = new Guid("d611c757-06a8-45ce-91c9-e53fa040d938"),
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
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

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime(6)");

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

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "simon@example.com",
                            Name = "Simon van der Weele",
                            PasswordHash = new byte[] { 84, 109, 18, 92, 168, 169, 46, 47, 128, 56, 38, 220, 71, 42, 193, 42, 144, 5, 229, 23, 194, 171, 82, 203, 200, 6, 82, 63, 135, 161, 144, 13, 2, 13, 58, 163, 110, 247, 40, 2, 180, 218, 132, 106, 191, 226, 134, 206, 36, 73, 222, 207, 114, 128, 113, 72, 75, 249, 93, 130, 60, 246, 91, 225 },
                            PasswordSalt = new byte[] { 70, 204, 86, 117, 208, 231, 43, 234, 207, 88, 150, 146, 146, 192, 98, 20, 95, 172, 223, 224, 212, 115, 114, 187, 226, 63, 212, 91, 113, 168, 251, 78, 111, 228, 22, 137, 139, 49, 163, 128, 144, 47, 57, 150, 228, 92, 82, 215, 156, 191, 25, 155, 209, 44, 36, 19, 105, 3, 180, 68, 91, 155, 42, 50, 3, 186, 63, 206, 120, 27, 219, 34, 73, 240, 2, 238, 8, 157, 86, 77, 163, 121, 159, 45, 193, 44, 233, 40, 92, 22, 31, 219, 34, 204, 231, 164, 190, 58, 144, 91, 220, 5, 156, 234, 185, 234, 8, 119, 225, 135, 165, 111, 199, 173, 8, 201, 206, 254, 34, 100, 144, 71, 167, 174, 145, 8, 232, 202 },
                            Ref = new Guid("484b3202-fc51-41a2-b509-ba3f7cbee93c"),
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
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
