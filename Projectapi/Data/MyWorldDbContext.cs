using Microsoft.EntityFrameworkCore;
using Projectapi.Data.Entities;

namespace Projectapi.Data
{
    public class MyWorldDbContext : DbContext
    {
        public MyWorldDbContext(DbContextOptions<MyWorldDbContext> context) : base(context)
        {
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerAddresses> customerAddresses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerAddresses>()
            .HasOne(_ => _.Customer)
            .WithMany(a => a.CustomerAddresses)
            .HasForeignKey(p => p.CustomerId);
        }
    }
}
