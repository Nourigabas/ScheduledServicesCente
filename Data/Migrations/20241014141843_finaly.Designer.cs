﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20241014141843_finaly")]
    partial class finaly
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsBooked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TheAppointment")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Domain.Models.CategoryService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SectorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UrlCategoryserviceIcon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SectorId");

                    b.ToTable("CategoryServices");
                });

            modelBuilder.Entity("Domain.Models.Evaluation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("EvaluationValue")
                        .HasColumnType("float");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ServiceOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.HasIndex("ServiceOwnerId");

                    b.ToTable("Evaluation");
                });

            modelBuilder.Entity("Domain.Models.PlatformManagers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlatformManagers");
                });

            modelBuilder.Entity("Domain.Models.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AppointmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId")
                        .IsUnique();

                    b.HasIndex("ServiceId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Domain.Models.Sector", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("TypeSector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlSectorIcon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sectors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e99f4b48-f6c5-4c0b-91a5-a2d6f7e7c392"),
                            Description = "Politics news in Syria",
                            IsAccepted = false,
                            IsDeleted = false,
                            TypeSector = "medicine",
                            UrlSectorIcon = ""
                        });
                });

            modelBuilder.Entity("Domain.Models.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SectorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ServiceOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryServiceId");

                    b.HasIndex("SectorId");

                    b.HasIndex("ServiceOwnerId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Domain.Models.ServiceOwner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<double>("EvaluationAverage")
                        .HasColumnType("float");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SectorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlCV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlImgPersonalIdentity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlImgWorkIdentity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SectorId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("OwnerServices");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EvaluationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOwner")
                        .HasColumnType("bit");

                    b.Property<Guid?>("OwnerServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EvaluationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Models.Appointment", b =>
                {
                    b.HasOne("Domain.Models.Service", "Service")
                        .WithMany("Appointments")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Domain.Models.CategoryService", b =>
                {
                    b.HasOne("Domain.Models.Sector", "Sector")
                        .WithMany("CategoryServices")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sector");
                });

            modelBuilder.Entity("Domain.Models.Evaluation", b =>
                {
                    b.HasOne("Domain.Models.Service", "Service")
                        .WithMany("Evaluations")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Models.ServiceOwner", "ServiceOwner")
                        .WithMany("Evaluations")
                        .HasForeignKey("ServiceOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");

                    b.Navigation("ServiceOwner");
                });

            modelBuilder.Entity("Domain.Models.Reservation", b =>
                {
                    b.HasOne("Domain.Models.Appointment", "Appointment")
                        .WithOne("Reservation")
                        .HasForeignKey("Domain.Models.Reservation", "AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Service", "Service")
                        .WithMany("Reservations")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");

                    b.Navigation("Service");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.Service", b =>
                {
                    b.HasOne("Domain.Models.CategoryService", "CategoryService")
                        .WithMany("Services")
                        .HasForeignKey("CategoryServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Sector", "Sector")
                        .WithMany("Services")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Models.ServiceOwner", "ServiceOwner")
                        .WithMany("Services")
                        .HasForeignKey("ServiceOwnerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CategoryService");

                    b.Navigation("Sector");

                    b.Navigation("ServiceOwner");
                });

            modelBuilder.Entity("Domain.Models.ServiceOwner", b =>
                {
                    b.HasOne("Domain.Models.Sector", "Sector")
                        .WithMany("ServiceOwners")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.User", "User")
                        .WithOne("ServiceOwner")
                        .HasForeignKey("Domain.Models.ServiceOwner", "UserId");

                    b.Navigation("Sector");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.HasOne("Domain.Models.Evaluation", "Evaluation")
                        .WithMany("Users")
                        .HasForeignKey("EvaluationId");

                    b.Navigation("Evaluation");
                });

            modelBuilder.Entity("Domain.Models.Appointment", b =>
                {
                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Domain.Models.CategoryService", b =>
                {
                    b.Navigation("Services");
                });

            modelBuilder.Entity("Domain.Models.Evaluation", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Models.Sector", b =>
                {
                    b.Navigation("CategoryServices");

                    b.Navigation("ServiceOwners");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("Domain.Models.Service", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Evaluations");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Domain.Models.ServiceOwner", b =>
                {
                    b.Navigation("Evaluations");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Navigation("Reservations");

                    b.Navigation("ServiceOwner");
                });
#pragma warning restore 612, 618
        }
    }
}