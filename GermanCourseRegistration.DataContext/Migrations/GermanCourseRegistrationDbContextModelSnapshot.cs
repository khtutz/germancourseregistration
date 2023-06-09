﻿// <auto-generated />
using System;
using GermanCourseRegistration.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GermanCourseRegistration.DataContext.Migrations
{
    [DbContext(typeof(GermanCourseRegistrationDbContext))]
    partial class GermanCourseRegistrationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<int>("Part")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.CourseMaterial", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("CourseMaterials");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.CourseMaterialOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<Guid>("RegistrationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RegistrationId")
                        .IsUnique();

                    b.ToTable("CourseMaterialOrders");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.CourseMaterialOrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseMaterialId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseMaterialOrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseMaterialId");

                    b.HasIndex("CourseMaterialOrderId");

                    b.ToTable("CourseMaterialOrderItems");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.CourseOffer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClassType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Cost")
                        .HasColumnType("money");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseOffers");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.Registration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseOfferId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("PaymentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CourseOfferId");

                    b.HasIndex("PaymentId")
                        .IsUnique()
                        .HasFilter("[PaymentId] IS NOT NULL");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Salutation")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.Timetable", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseOfferId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DayName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("EndTimeHour")
                        .HasColumnType("int");

                    b.Property<int>("EndTimeMinute")
                        .HasColumnType("int");

                    b.Property<int>("StartTimeHour")
                        .HasColumnType("int");

                    b.Property<int>("StartTimeMinute")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseOfferId");

                    b.ToTable("Timetables");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.CourseMaterialOrder", b =>
                {
                    b.HasOne("GermanCourseRegistration.EntityModels.Registration", "Registration")
                        .WithOne("CourseMaterialOrder")
                        .HasForeignKey("GermanCourseRegistration.EntityModels.CourseMaterialOrder", "RegistrationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.CourseMaterialOrderItem", b =>
                {
                    b.HasOne("GermanCourseRegistration.EntityModels.CourseMaterial", "CourseMaterial")
                        .WithMany("CourseMaterialOrderItems")
                        .HasForeignKey("CourseMaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GermanCourseRegistration.EntityModels.CourseMaterialOrder", "CourseMaterialOrder")
                        .WithMany("CourseMaterialOrderItems")
                        .HasForeignKey("CourseMaterialOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseMaterial");

                    b.Navigation("CourseMaterialOrder");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.CourseOffer", b =>
                {
                    b.HasOne("GermanCourseRegistration.EntityModels.Course", "Course")
                        .WithMany("CourseOffers")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.Registration", b =>
                {
                    b.HasOne("GermanCourseRegistration.EntityModels.CourseOffer", "CourseOffer")
                        .WithMany("Registrations")
                        .HasForeignKey("CourseOfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GermanCourseRegistration.EntityModels.Payment", "Payment")
                        .WithOne("Registration")
                        .HasForeignKey("GermanCourseRegistration.EntityModels.Registration", "PaymentId");

                    b.HasOne("GermanCourseRegistration.EntityModels.Student", "Student")
                        .WithOne("Registration")
                        .HasForeignKey("GermanCourseRegistration.EntityModels.Registration", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseOffer");

                    b.Navigation("Payment");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.Timetable", b =>
                {
                    b.HasOne("GermanCourseRegistration.EntityModels.CourseOffer", "CourseOffer")
                        .WithMany("Timetables")
                        .HasForeignKey("CourseOfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseOffer");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.Course", b =>
                {
                    b.Navigation("CourseOffers");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.CourseMaterial", b =>
                {
                    b.Navigation("CourseMaterialOrderItems");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.CourseMaterialOrder", b =>
                {
                    b.Navigation("CourseMaterialOrderItems");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.CourseOffer", b =>
                {
                    b.Navigation("Registrations");

                    b.Navigation("Timetables");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.Payment", b =>
                {
                    b.Navigation("Registration");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.Registration", b =>
                {
                    b.Navigation("CourseMaterialOrder");
                });

            modelBuilder.Entity("GermanCourseRegistration.EntityModels.Student", b =>
                {
                    b.Navigation("Registration");
                });
#pragma warning restore 612, 618
        }
    }
}
