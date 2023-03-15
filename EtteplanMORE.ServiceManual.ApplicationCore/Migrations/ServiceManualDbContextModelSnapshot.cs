﻿// <auto-generated />
using System;
using EtteplanMORE.ServiceManual.ApplicationCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EtteplanMORE.ServiceManual.ApplicationCore.Migrations
{
    [DbContext(typeof(ServiceManualDbContext))]
    partial class ServiceManualDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EtteplanMORE.ServiceManual.ApplicationCore.Entities.FactoryDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeviceYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FactoryDevices");
                });

            modelBuilder.Entity("EtteplanMORE.ServiceManual.ApplicationCore.Entities.MaintenanceTasks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DiscriptionTask")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FactoryDeviceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegisteredTimeTask")
                        .HasColumnType("datetime2");

                    b.Property<int>("SeverityTask")
                        .HasColumnType("int");

                    b.Property<int>("StatusTask")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FactoryDeviceId");

                    b.ToTable("MaintenanceTasks");
                });

            modelBuilder.Entity("EtteplanMORE.ServiceManual.ApplicationCore.Entities.MaintenanceTasks", b =>
                {
                    b.HasOne("EtteplanMORE.ServiceManual.ApplicationCore.Entities.FactoryDevice", null)
                        .WithMany("Maintenances")
                        .HasForeignKey("FactoryDeviceId");
                });

            modelBuilder.Entity("EtteplanMORE.ServiceManual.ApplicationCore.Entities.FactoryDevice", b =>
                {
                    b.Navigation("Maintenances");
                });
#pragma warning restore 612, 618
        }
    }
}
