using Microsoft.EntityFrameworkCore;
using NewAutoTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewAutoTech.Data
{
    public class AppDbContext  : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Autos> Autos { get; set; }
        public DbSet<Owners> Owners { get; set; }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autos>().HasKey(x => x.AutoID);

            modelBuilder.Entity<Owners>().HasKey(x => x.OwnerID);

            modelBuilder.Entity<AutosAndOwners>().HasKey(x => new { x.Autoid, x.Ownerid });

            modelBuilder.Entity<AutosAndOwners>().HasOne(x => x.Autos).WithMany(m => m.AutosOwners).HasForeignKey(x => x.Autoid);

            modelBuilder.Entity<AutosAndOwners>().HasOne(x => x.Owners).WithMany(m => m.OwnersAutos).HasForeignKey(x => x.Ownerid);
        }


    }
}
