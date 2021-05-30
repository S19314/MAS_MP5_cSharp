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

            // UP комментить или при добавлении новых данных он будет сравнивать с пролшлым? И добавлять новое, а старое не трогать и не матюкаться

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
        }
        
    }
}
