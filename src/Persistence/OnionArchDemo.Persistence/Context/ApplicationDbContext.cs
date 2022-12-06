using Microsoft.EntityFrameworkCore;
using OnionArchDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchDemo.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Pen",
                    Quentity = 5,
                    Value = 12
                },
                          new Product()
                          {
                              Id = Guid.NewGuid(),
                              Name = "Table",
                              Quentity = 3,
                              Value = 23
                          },
                                    new Product()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "Book",
                                        Quentity = 12,
                                        Value = 76
                                    }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
