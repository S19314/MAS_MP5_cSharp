﻿// <auto-generated />
using MP5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MP5.Migrations
{
    [DbContext(typeof(ArmyDbContext))]
    [Migration("20210530171156_AddedFirearmInheritanceTable")]
    partial class AddedFirearmInheritanceTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MP5.Models.Firearm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BulletSpeed")
                        .HasColumnType("float");

                    b.Property<double>("FireDistance")
                        .HasColumnType("float");

                    b.Property<int>("MagazineSize")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Firearm");
                });

            modelBuilder.Entity("MP5.Models.Soldier", b =>
                {
                    b.Property<int>("IdSoldier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Rank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdSoldier");

                    b.ToTable("Soilder");
                });

            modelBuilder.Entity("MP5.Models.Warehouse", b =>
                {
                    b.Property<int>("IdWarehouse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<int>("CapacityInBoxes")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("IdWarehouse");

                    b.ToTable("Warehouse");
                });

            modelBuilder.Entity("MP5.Models.AssaultRifle", b =>
                {
                    b.HasBaseType("MP5.Models.Firearm");

                    b.Property<string>("FireMode")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.ToTable("AssaultRifle");
                });

            modelBuilder.Entity("MP5.Models.SniperRifle", b =>
                {
                    b.HasBaseType("MP5.Models.Firearm");

                    b.Property<double>("MaximalScopeMagnification")
                        .HasColumnType("float");

                    b.Property<double>("MinimalScopeMagnification")
                        .HasColumnType("float");

                    b.ToTable("SniperRifle");
                });

            modelBuilder.Entity("MP5.Models.AssaultRifle", b =>
                {
                    b.HasOne("MP5.Models.Firearm", null)
                        .WithOne()
                        .HasForeignKey("MP5.Models.AssaultRifle", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MP5.Models.SniperRifle", b =>
                {
                    b.HasOne("MP5.Models.Firearm", null)
                        .WithOne()
                        .HasForeignKey("MP5.Models.SniperRifle", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
