using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Value> Values {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
                .HasData(
                    new Value {Id = 1, Name = "Value 101"},
                    new Value {Id = 2, Name = "Value 201"},
                    new Value {Id = 3, Name = "Value 301"},
                    new Value {Id = 4, Name = "Value 401"},
                    new Value {Id = 5, Name = "Value 501"},
                    new Value {Id = 6, Name = "Value 601"},
                    new Value {Id = 7, Name = "Value 701"}
                );
        }
    }
}
