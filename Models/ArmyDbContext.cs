using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP5.Models
{
    public class ArmyDbContext : DbContext
    {
        public DbSet<Soldier> Soldiers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Firearm> Firearms { get; set; }
        public DbSet<SniperRifle> SniperRifles { get; set; }
        public DbSet<AssaultRifle> AssaultRifles { get; set; }
        public ArmyDbContext() { }
        public ArmyDbContext(DbContextOptions<ArmyDbContext> options) : base(options)
        {
        //            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-QBPEBIC\DEVELOPERDB;Database=Army;Trusted_Connection=True;");
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Soldier>()
                .ToTable("Soilder");
            modelBuilder.Entity<Soldier>()
                        .HasKey(e => e.IdSoldier);
            modelBuilder.Entity<Soldier>()
                .Property(e => e.FirstName)
                .HasMaxLength(100);
            modelBuilder.Entity<Soldier>()
                .Property(e => e.SecondName)
                .HasMaxLength(100);


            modelBuilder.Entity<Warehouse>()
                .ToTable("Warehouse");
            modelBuilder.Entity<Warehouse>()
                        .HasKey(e => e.IdWarehouse);
            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Name)
                .HasMaxLength(60);
            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Address)
                .HasMaxLength(120);
            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Address)
                .HasMaxLength(120);


            modelBuilder.Entity<Firearm>()
                .ToTable("Firearm");
            modelBuilder.Entity<Firearm>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Firearm>()
                .Property(e => e.Name)
                .HasMaxLength(100);

            modelBuilder.Entity<AssaultRifle>()
                .ToTable("AssaultRifle");
            modelBuilder.Entity<AssaultRifle>()
                .Property(e => e.FireMode)
                .HasMaxLength(100);

            modelBuilder.Entity<SniperRifle>()
                .ToTable("SniperRifle");

            /*
            modelBuilder.Entity<Firearm>()
                .Property(e => e.Id)
                .dele ;
            */

        }
        
    }
}
