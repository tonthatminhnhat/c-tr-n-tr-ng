﻿// <auto-generated />
using System;
using EFCoreTutorial.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreTutorial.Migrations
{
    [DbContext(typeof(StudentDB))]
    partial class StudentDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("EFCoreTutorial.Model.Classroom", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Room")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Teacher")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Classroom");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "CNTTK44H",
                            Room = "Lab1",
                            Teacher = "Hùng Dung"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "CNTTK44B",
                            Room = "Lab3",
                            Teacher = "Hùng Dung2"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "CNTTK44A",
                            Room = "Lab2",
                            Teacher = "Hùng Dung3"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "CNTTK44L",
                            Room = "Lab7",
                            Teacher = "Hùng Dung7"
                        });
                });

            modelBuilder.Entity("EFCoreTutorial.Model.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DDB")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<long>("IdClassroom")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("POB")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IdClassroom");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("EFCoreTutorial.Model.Student", b =>
                {
                    b.HasOne("EFCoreTutorial.Model.Classroom", "Classroom")
                        .WithMany("Students")
                        .HasForeignKey("IdClassroom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classroom");
                });

            modelBuilder.Entity("EFCoreTutorial.Model.Classroom", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
