using Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class GoldenDbContext : DbContext
    {
        public GoldenDbContext(DbContextOptions<GoldenDbContext> options)
            : base(options)
        {
        }
        public DbSet<TbAbout> TbAbouts { get; set; }
        public DbSet<TbBooking> TbBookings { get; set; }
        public DbSet<TbContact> TbContacts { get; set; }
        public DbSet<TbCustomer> TbCustomers { get; set; }
        public DbSet<TbCustomerReview> TbCustomerReviews { get; set; }
        public DbSet<TbNews> TbNews { get; set; }
        public DbSet<TbService> TbServices { get; set; }
        public DbSet<TbTechnician> TbTechnicians { get; set; }
        public DbSet<TbUser> TbUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TbCustomer>()
                    .HasMany(c => c._TbBookings)
                    .WithOne(b => b._TbCustomer)
                    .HasForeignKey(b => b.CustomerID);

            modelBuilder.Entity<TbService>()
                    .HasMany(a => a._TbBookings)
                    .WithOne(b => b._TbService)
                    .HasForeignKey(c => c.ServiceID);

            modelBuilder.Entity<TbCustomer>()
                    .HasMany(a => a._TbCustomerReviews)
                    .WithOne(b => b._TbCustomer)
                    .HasForeignKey(c => c.CustomerID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
