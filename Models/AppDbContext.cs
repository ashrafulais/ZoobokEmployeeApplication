using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> context) : base(context)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>(e =>
            {
                e.HasKey(k => k.Id);
                e.Property(p => p.Id).ValueGeneratedOnAdd();
            });

            builder.Entity<Employee>()
                .HasData( new Employee { Id=1, FirstName = "Ashraful", MiddleName = "S.", LastName = "Islam" } );
            base.OnModelCreating(builder);
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
