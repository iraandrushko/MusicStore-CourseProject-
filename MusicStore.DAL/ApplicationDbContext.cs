using MusicStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace MusicStore.DAL
{
    public partial class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<CreditCard> CreditCards { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Track> Tracks { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Genre> Genres { get; set; }


        public ApplicationDbContext()
        {
            var dbJustCreated = Database.EnsureCreated();
            if (dbJustCreated) 
            {
                Seed();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MusicStore;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CreditCard>()
            //modelBuilder.Entity<User>()
            //    .HasOne(u => u.CreditCard)
            //    .WithOne(c => c.User) 
            //    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
