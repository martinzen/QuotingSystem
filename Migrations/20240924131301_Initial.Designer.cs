﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Solar1.Data;

#nullable disable

namespace AspnetCoreMvcFull.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240924131301_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspnetCoreMvcFull.Models.QuoteEntry", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ABNnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NMI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFirst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameLast")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("companyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("electricityDis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("electricityRetailer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("installationAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("meterNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("preapprovalNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("propertyPhase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("roofType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("storyHouse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("switchBoardUpgrade")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("QuoteEntries");
                });
#pragma warning restore 612, 618
        }
    }
}