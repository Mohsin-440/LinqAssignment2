﻿// <auto-generated />
using System;
using Linq_Assignment_2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Linq_Assignment_2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231212114754_DateUpdate")]
    partial class DateUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Linq_Assignment_2.Models.Class", b =>
                {
                    b.Property<int>("Cid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Cid"));

                    b.Property<int>("FacultyFid")
                        .HasColumnType("integer");

                    b.Property<int>("Fid")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Cid");

                    b.HasIndex("FacultyFid");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Linq_Assignment_2.Models.Enrolled", b =>
                {
                    b.Property<int>("EnrolledId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EnrolledId"));

                    b.Property<int>("Cid")
                        .HasColumnType("integer");

                    b.Property<int>("ClassCid")
                        .HasColumnType("integer");

                    b.Property<int>("Sid")
                        .HasColumnType("integer");

                    b.Property<int>("StudentSid")
                        .HasColumnType("integer");

                    b.HasKey("EnrolledId");

                    b.HasIndex("ClassCid");

                    b.HasIndex("StudentSid");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("Linq_Assignment_2.Models.Faculty", b =>
                {
                    b.Property<int>("Fid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Fid"));

                    b.Property<DateOnly>("Birthdate")
                        .HasColumnType("date");

                    b.Property<string>("DeptId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Standing")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Fid");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("Linq_Assignment_2.Models.Student", b =>
                {
                    b.Property<int>("Sid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Sid"));

                    b.Property<DateOnly>("Birthdate")
                        .HasColumnType("date");

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Standing")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Sid");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Linq_Assignment_2.Models.Class", b =>
                {
                    b.HasOne("Linq_Assignment_2.Models.Faculty", "Faculty")
                        .WithMany("Classes")
                        .HasForeignKey("FacultyFid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Linq_Assignment_2.Models.Enrolled", b =>
                {
                    b.HasOne("Linq_Assignment_2.Models.Class", "Class")
                        .WithMany("Enrollments")
                        .HasForeignKey("ClassCid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Linq_Assignment_2.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentSid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Linq_Assignment_2.Models.Class", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("Linq_Assignment_2.Models.Faculty", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("Linq_Assignment_2.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
