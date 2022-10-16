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
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MusicStore1;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>()
            //    .HasOne(u => u.CreditCard)
            //    .WithOne(c => c.User)
            //    .HasForeignKey<CreditCard>(c => c.UserId)
            //    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
