﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectDeAn.Database;

namespace WindowsFromsApp1.Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200524085245_2stMigration")]
    partial class _2stMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WindowsFromsApp1.Database.Entities.DataHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AirTemperature")
                        .HasColumnType("float");

                    b.Property<double>("CO2")
                        .HasColumnType("float");

                    b.Property<double>("Humidity")
                        .HasColumnType("float");

                    b.Property<double>("Illumintation")
                        .HasColumnType("float");

                    b.Property<double>("Ph")
                        .HasColumnType("float");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("SoilMoisture")
                        .HasColumnType("float");

                    b.Property<double>("SoilTemperature")
                        .HasColumnType("float");

                    b.Property<int>("ZoneId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZoneId");

                    b.ToTable("DataHistories");
                });

            modelBuilder.Entity("WindowsFromsApp1.Database.Entities.Strategy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AirTemperature")
                        .HasColumnType("float");

                    b.Property<double>("CO2")
                        .HasColumnType("float");

                    b.Property<double>("Humidity")
                        .HasColumnType("float");

                    b.Property<double>("Illumintation")
                        .HasColumnType("float");

                    b.Property<double>("Ph")
                        .HasColumnType("float");

                    b.Property<double>("SoilMoisture")
                        .HasColumnType("float");

                    b.Property<double>("SoilTemperature")
                        .HasColumnType("float");

                    b.Property<string>("StrategyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Strategies");
                });

            modelBuilder.Entity("WindowsFromsApp1.Database.Entities.Zone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StrategyId")
                        .HasColumnType("int");

                    b.Property<string>("ZoneName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StrategyId");

                    b.ToTable("Zones");
                });

            modelBuilder.Entity("WindowsFromsApp1.Database.Entities.DataHistory", b =>
                {
                    b.HasOne("WindowsFromsApp1.Database.Entities.Zone", "Zone")
                        .WithMany()
                        .HasForeignKey("ZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WindowsFromsApp1.Database.Entities.Zone", b =>
                {
                    b.HasOne("WindowsFromsApp1.Database.Entities.Strategy", "Strategy")
                        .WithMany()
                        .HasForeignKey("StrategyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
