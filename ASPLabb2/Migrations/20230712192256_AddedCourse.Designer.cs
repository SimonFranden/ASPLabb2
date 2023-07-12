﻿// <auto-generated />
using ASPLabb2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPLabb2.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230712192256_AddedCourse")]
    partial class AddedCourse
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASPLabb2.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClassName = "1A"
                        },
                        new
                        {
                            Id = 2,
                            ClassName = "2B"
                        },
                        new
                        {
                            Id = 3,
                            ClassName = "3B"
                        },
                        new
                        {
                            Id = 4,
                            ClassName = "1B"
                        },
                        new
                        {
                            Id = 5,
                            ClassName = "2B"
                        },
                        new
                        {
                            Id = 6,
                            ClassName = "3B"
                        });
                });

            modelBuilder.Entity("ASPLabb2.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Programmering 1",
                            TeacherId = 4
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Matte",
                            TeacherId = 2
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Programmering 2",
                            TeacherId = 3
                        });
                });

            modelBuilder.Entity("ASPLabb2.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClassId = 1,
                            FName = "Sven",
                            LName = "Svensson"
                        },
                        new
                        {
                            Id = 2,
                            ClassId = 1,
                            FName = "Olof",
                            LName = "Olofsson"
                        },
                        new
                        {
                            Id = 3,
                            ClassId = 4,
                            FName = "Sten",
                            LName = "Stensson"
                        },
                        new
                        {
                            Id = 4,
                            ClassId = 4,
                            FName = "Gustaf",
                            LName = "Gustafsson"
                        },
                        new
                        {
                            Id = 5,
                            ClassId = 4,
                            FName = "Clark",
                            LName = "Olofsson"
                        });
                });

            modelBuilder.Entity("ASPLabb2.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourses");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = 1,
                            CourseId = 2
                        },
                        new
                        {
                            StudentId = 1,
                            CourseId = 3
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 2
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 3
                        },
                        new
                        {
                            StudentId = 3,
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = 3,
                            CourseId = 2
                        },
                        new
                        {
                            StudentId = 3,
                            CourseId = 3
                        },
                        new
                        {
                            StudentId = 4,
                            CourseId = 2
                        },
                        new
                        {
                            StudentId = 4,
                            CourseId = 3
                        },
                        new
                        {
                            StudentId = 5,
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = 5,
                            CourseId = 3
                        });
                });

            modelBuilder.Entity("ASPLabb2.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FName = "Elon",
                            LName = "Musk"
                        },
                        new
                        {
                            Id = 2,
                            FName = "Bill",
                            LName = "Gates"
                        },
                        new
                        {
                            Id = 3,
                            FName = "Mark",
                            LName = "Zuckerberg"
                        },
                        new
                        {
                            Id = 4,
                            FName = "Reidar",
                            LName = "Nilsen"
                        },
                        new
                        {
                            Id = 5,
                            FName = "Tobias",
                            LName = "Landén"
                        });
                });

            modelBuilder.Entity("ASPLabb2.Models.Course", b =>
                {
                    b.HasOne("ASPLabb2.Models.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ASPLabb2.Models.Student", b =>
                {
                    b.HasOne("ASPLabb2.Models.Class", null)
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASPLabb2.Models.StudentCourse", b =>
                {
                    b.HasOne("ASPLabb2.Models.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASPLabb2.Models.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ASPLabb2.Models.Class", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("ASPLabb2.Models.Course", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("ASPLabb2.Models.Student", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("ASPLabb2.Models.Teacher", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
