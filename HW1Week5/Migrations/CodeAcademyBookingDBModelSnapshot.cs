﻿// <auto-generated />
using System;
using HW1Week5.MyDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HW1Week5.Migrations
{
    [DbContext(typeof(CodeAcademyBookingDB))]
    partial class CodeAcademyBookingDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HW1Week5.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<int>("BookingDate")
                        .HasColumnType("int");

                    b.Property<int>("BookingTime")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SpaceID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.HasIndex("SpaceID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("HW1Week5.Models.Space", b =>
                {
                    b.Property<int>("SpaceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpaceID"));

                    b.Property<double>("AvaliableSpace")
                        .HasColumnType("float");

                    b.Property<DateOnly>("SpaceDate")
                        .HasColumnType("date");

                    b.Property<string>("SpaceDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("SpaceTime")
                        .HasColumnType("time");

                    b.HasKey("SpaceID");

                    b.ToTable("spaces");
                });

            modelBuilder.Entity("HW1Week5.Models.Booking", b =>
                {
                    b.HasOne("HW1Week5.Models.Space", null)
                        .WithMany("bookings")
                        .HasForeignKey("SpaceID");
                });

            modelBuilder.Entity("HW1Week5.Models.Space", b =>
                {
                    b.Navigation("bookings");
                });
#pragma warning restore 612, 618
        }
    }
}