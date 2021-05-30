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
        public ArmyDbContext() { }
        public ArmyDbContext(DbContextOptions<ArmyDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Soldier>()
                        .HasKey(e => e.IdSoldier);
            modelBuilder.Entity<Soldier>()
                .Property(e => e.FirstName)
                .HasMaxLength(100);
            modelBuilder.Entity<Soldier>()
                .Property(e => e.SecondName)
                .HasMaxLength(100);

        }
    }
}
